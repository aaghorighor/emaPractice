namespace Suftnet.Cos.Services
{  
    using System;
    using System.Net.Mail;
    using System.Threading;
    using System.Linq;

    using Model;
    using Suftnet.Co.Ema.Api.Models;
    using Microsoft.Extensions.Options;
    using Microsoft.Extensions.Logging;

    public class Smtp : ISmtp
    {
        private int m_Pool;
        private System.Threading.ManualResetEvent m_WaitingFreeThread;
        private readonly Config _config;
        private readonly ILogger<Smtp> _logger;

        public Smtp(IOptions<Config> config, ILogger<Smtp> logger)
        {
            this.m_Pool = 0;
            _config = config.Value;
            _logger = logger;
            m_WaitingFreeThread = new System.Threading.ManualResetEvent(false);
        }

        public void MailProcessor(MessageModel messageModel)
        {
           var callBack = new System.Threading.WaitCallback((state) =>
           {               
			   var p = state as MessageModel;

               try
				{
					if (p != null)
					{
						SendEmail(p);
					}
				}
				catch (Exception ex)
				{
                   _logger.LogError($"Smtp Server Error: {ex}");
               }
               finally
				{
                   Interlocked.Decrement(ref m_Pool);				   

					if (m_Pool < 1)
					{
						m_WaitingFreeThread.Set();
					}
               }
           });

           if (m_Pool > 5)
           {
               m_WaitingFreeThread.WaitOne();
           }

           Interlocked.Increment(ref m_Pool);

           System.Threading.ThreadPool.QueueUserWorkItem(callBack, messageModel);

           m_WaitingFreeThread.Reset();
        }

        private void SendEmail(MessageModel messageModel)
        {
            var message = (System.Net.Mail.MailMessage)messageModel.MailMessage;           
                       
            if (!message.Headers.AllKeys.Any(i => i == "Suftnet-Mailer"))
            {
                message.Headers.Add("Suftnet-Mailer", "Suftnet.MailServices");
            }
            else
            {
                message.Headers["Suftnet-Mailer"] = "Suftnet.MailServices";
            }

            var htmlView = AlternateView.CreateAlternateViewFromString(message.Body, null, "text/html");

            htmlView.TransferEncoding = System.Net.Mime.TransferEncoding.QuotedPrintable;

            message.AlternateViews.Add(htmlView);

            using (var sender = GetSmtpClient())
            {
                sender.Send(message);
            }
        }

        System.Net.Mail.SmtpClient GetSmtpClient()
        {
            var sender = new System.Net.Mail.SmtpClient();

            sender.EnableSsl = false;
            sender.Host = _config.SmtpServer;
            sender.Port = Convert.ToInt32(_config.Port);
           
            sender.Credentials = new System.Net.NetworkCredential(_config.UserName, _config.Password);             
            sender.SendCompleted += new System.Net.Mail.SendCompletedEventHandler(sender_SendCompleted);

            return sender;
        }

        void sender_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                return;
            }

            if (e.Error == null)
            {
                return;
            }

            var messageToProcess = e.UserState as MessageModel;
            if (messageToProcess == null)
            {
                return;
            }

            try
            {
                _logger.LogInformation($"Email mail was sent successfully {messageToProcess.MailMessage.Subject}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Smtp Server Error: {ex}");
            }
        }        
    }
}
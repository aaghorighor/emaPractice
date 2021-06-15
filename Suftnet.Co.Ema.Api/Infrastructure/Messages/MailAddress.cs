using Suftnet.Co.Ema.Common;

namespace Suftnet.Cos.Model
{
  
    public class MailAddress
    {
        public MailAddress()
        {
            SendingType = EmailSendingType.To;
        }
        
        public string Address { get; set; }
    
        public string DisplayName { get; set; }
       
        public EmailSendingType SendingType { get; set; }
    }
}
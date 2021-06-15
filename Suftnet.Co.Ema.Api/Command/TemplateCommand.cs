namespace Suftnet.Co.Ema.Api.Command
{
    using Microsoft.Extensions.Logging;
    using System;
    using System.IO;

    public class TemplateCommand : ITemplateCommand
    {
        public string View { get; set; }
        public string VIEW_PATH { get; set; }

        private readonly ILogger<TemplateCommand> _logger;

        public TemplateCommand(ILogger<TemplateCommand> logger)
        {
            _logger = logger;
        }

        public void Execute()
        {
            CreateView();
        }

        #region private function

        private void CreateView()
        {
            this.View = ReadFile();
        }

        private string ReadFile()
        {
            try
            {
                string htmlString = File.ReadAllText(this.VIEW_PATH);
                return htmlString;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Template read error {ex}");
            }

            return string.Empty;
        }

        #endregion
    }
}

namespace Suftnet.Co.Ema.Api.Command
{
   public interface ITemplateCommand
   {
        string View { get; set; }
        string VIEW_PATH { get; set; }
        void Execute();
   }
}

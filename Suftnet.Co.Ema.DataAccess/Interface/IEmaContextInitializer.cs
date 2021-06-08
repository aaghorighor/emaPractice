namespace Suftnet.Co.Ema.DataAccess.Interface
{
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;

    public interface IEmaContextInitializer
    {
        Task SeedAsync(IConfiguration configuration);
    }
}

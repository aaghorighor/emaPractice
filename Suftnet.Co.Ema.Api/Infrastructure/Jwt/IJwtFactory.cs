namespace Suftnet.Co.Ema.Api.Infrastructure
{
    using Suftnet.Co.Ema.DataAccess.Identity;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public interface IJwtFactory
    {
        Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(ApplicationUser applicationUser);
    }
}

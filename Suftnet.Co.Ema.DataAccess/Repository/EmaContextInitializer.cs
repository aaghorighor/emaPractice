namespace Suftnet.Co.Ema.DataAccess.Repository
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    using Suftnet.Co.Ema.DataAccess.Actions;
    using Suftnet.Co.Ema.DataAccess.Identity;
    using Suftnet.Co.Ema.DataAccess.Interface;

    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class EmaContextInitializer : IEmaContextInitializer
    {
        private readonly DataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;
       

        public EmaContextInitializer(DataContext context, 
            UserManager<ApplicationUser> userManager, 
            ILogger<EmaContextInitializer> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;          

        }
        public async Task SeedAsync(IConfiguration configuration)
        {
            await _context.Database.MigrateAsync().ConfigureAwait(false);
            CreateUsers();          
        }

        #region
        private void CreateUsers()
        {
            try {

                if (!_context.Users.Any())
                {
                    var adminUser = new ApplicationUser { UserName = "admin@admin.com", FirstName = "Admin first", LastName = "Admin last", Email = "admin@admin.com", PhoneNumber = "0123456789", EmailConfirmed = true, CreatedAt = DateTime.Now, IsEnabled = true };
                    adminUser.Id = Guid.NewGuid().ToString();
                    _userManager.CreateAsync(adminUser, "P@ssw0rd!").Result.ToString();                 

                    _context.SaveChanges();
                }

            }
            catch(Exception ex)
            {
                _logger.LogError(ex,"",null);
            };           

        }    

        #endregion
    }
}

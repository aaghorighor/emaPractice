namespace Suftnet.Co.Ema.DataAccess.Repository
{
    using Suftnet.Co.Ema.DataAccess.Interface;
    using Suftnet.Co.Ema.DataAccess.Actions;
    
    public class UnitOfWork : IUnitOfWork
    {
        readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}

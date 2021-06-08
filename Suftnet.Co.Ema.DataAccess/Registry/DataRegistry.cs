namespace Suftnet.Co.Ema.DataAccess.Registry
{   
    using StructureMap;
    using Suftnet.Co.Ema.DataAccess.Interface;
    using Suftnet.Co.Ema.DataAccess.Repository;

    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            Scan(x =>
            {
                x.TheCallingAssembly();
                x.WithDefaultConventions();               
            });

            For(typeof(IRepository<>)).Use(typeof(Repository<>)).Transient();
            For<IEmaContextInitializer>().Use<EmaContextInitializer>().Transient();
            For<IUnitOfWork>().Use<UnitOfWork>().Transient();           
        }
    }
}
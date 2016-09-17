
namespace ErisData.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ErisDataContext dbContext;

        public ErisDataContext Init()
        {
            return dbContext ?? (dbContext = new ErisDataContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

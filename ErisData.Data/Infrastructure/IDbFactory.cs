using System;

namespace ErisData.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ErisDataContext Init();
    }
}

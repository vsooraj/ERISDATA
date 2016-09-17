using System.Data.Entity.ModelConfiguration;
using ErisData.Entities;
namespace ErisData.Data
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.ID);
        }
    }
}

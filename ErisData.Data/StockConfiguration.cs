using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErisData.Entities;

namespace ErisData.Data
{
    public class StockConfiguration : EntityBaseConfiguration<Stock>
    {
        public StockConfiguration()
        {
            Property(s => s.ItemId).IsRequired();
            Property(s => s.UniqueKey).IsRequired();
            Property(s => s.IsAvailable).IsRequired();
            HasMany(s => s.Rentals).WithRequired(r => r.Stock).HasForeignKey(r => r.StockId);
        }
    }
}

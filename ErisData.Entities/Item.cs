using System.Collections.Generic;

namespace ErisData.Entities
{

    public class Item : IEntityBase
    {
        public Item()
        {
            Stocks = new List<Stock>();
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TrailerURI { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}

using data_access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class Bought:IEntity
    {
        public int Id { get; set; }
      
        public int Price { get; set; }
        public int SallerId { get; set; }
        public Seller Seller { get; set; }
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public virtual ICollection<MusicRecord> MusicRecords { get; set; }

    }
}

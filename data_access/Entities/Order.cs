using data_access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string Sum { get; set; }
        public bool IsBought { get; set; }
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
    }
}

using data_access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class MusicRecord : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Price { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual ICollection<Bought> Boughts { get; set; }

    }
}

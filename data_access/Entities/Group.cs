using data_access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class Group : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfPeople { get; set; }
        public virtual ICollection<MusicRecord> MusicRecords { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }

    }
}

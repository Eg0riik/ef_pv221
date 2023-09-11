using data_access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class Track : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Longth { get; set; }
        public int NumberOfAuditions { get; set; }
        public int MusicalRecordId { get; set; }
        public MusicRecord MusicRecords { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int GanreId { get; set; }
        public Genre Genre { get; set; }
    }
}

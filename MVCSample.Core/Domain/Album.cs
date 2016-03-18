using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample.Core.Domain
{
    public class Album : BaseEntity
    {
        public string AlbumName { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}

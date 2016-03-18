using MVCSample.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample.Data.Mapping
{
    /// <summary>
    /// Declare class to map Album Entity
    /// To tbl_Album Table
    /// </summary>
    class AlbumMap : EntityTypeConfiguration<Album>
    {
        public AlbumMap()
        {
            this.ToTable("tbl_Album");
            this.HasKey(s => s.Id);
        }
    }
}

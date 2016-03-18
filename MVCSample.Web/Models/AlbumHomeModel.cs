using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample.Web.Models
{
    public class AlbumHomeModel
    {
        public AlbumHomeModel()
        {
            Albums = new List<Album>();
        }
        public List<Album> Albums { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSample.Web.Models
{
    public class AlbumDetailModel
    {
        public int AlbumID { get; set; }

        [DisplayName("Album Name")]
        public string AlbumName { get; set; }
        [DisplayName("Artist")]
        public string Artist { get; set; }
        [DisplayName("Genre")]
        public string Genre { get; set; }
    }
}
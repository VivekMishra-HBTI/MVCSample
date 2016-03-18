using MVCSample.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample.Services
{
    /// <summary>
    /// This interface contains all the methods
    /// to be defined in the local db service AlbumService
    /// </summary>
    public interface IAlbumService
    {
        /// <summary>
        /// method to Get records from tbl_Album table
        /// </summary>
        List<AlbumServiceModel> GetAlbumData();
        ///Isert record in table tbl_Album 
        /// </summary>
        AlbumServiceModel InsertAlbum(AlbumServiceModel albumModel);
        /// <summary>
        ///Update record in table tbl_CardDetails 
        /// </summary>
        AlbumServiceModel UpdateAlbum(AlbumServiceModel albumModel);
    }
}

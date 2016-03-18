using MVCSample.Core.Domain;
using MVCSample.Data;
using MVCSample.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample.Services
{
    /// <summary>
    /// This class contains all the methods for the local db service
    /// </summary>
    public class AlbumService : IAlbumService
    {

        #region private variables
        //declare all the private variables here
        private IRepository<Album> _albumRepository;
        //private IDbContext _albumContext;
        #endregion

        #region constructors
        //define the constructors for this class here

        public AlbumService(IRepository<Album> albumRepository)
        {
            _albumRepository = albumRepository;

        }
        #endregion

        #region Album methods
        /// <summary>
        /// method to Get record from tbl_Album table
        /// </summary>
        public List<AlbumServiceModel> GetAlbumData()
        {
            List<AlbumServiceModel> albumList = new List<AlbumServiceModel>();
            foreach (Album item in _albumRepository.Table.ToList<Album>())
            {
                AlbumServiceModel currentItem = new AlbumServiceModel();
                currentItem.PopulateModelFromCoreEntity(item);
                albumList.Add(currentItem);
            }
            return albumList;
        }
        #endregion

        /// <summary>
        ///Isert record in table tbl_Album 
        /// </summary>
        public AlbumServiceModel InsertAlbum(AlbumServiceModel albumModel)
        {
            Album coreAlbum = new Album();
            albumModel.PopulateCoreEntityFromModel(coreAlbum);
            _albumRepository.Insert(coreAlbum);
            albumModel.PopulateModelFromCoreEntity(coreAlbum);
            return albumModel;
        }
        /// <summary>
        ///Update record in table tbl_Album 
        /// </summary>
        public AlbumServiceModel UpdateAlbum(AlbumServiceModel albumModel)
        {
            Album coreAlbum = _albumRepository.GetById(albumModel.AlbumID);
            albumModel.PopulateCoreEntityFromModel(coreAlbum);
            _albumRepository.Update(coreAlbum);
            albumModel.PopulateModelFromCoreEntity(coreAlbum);
            return albumModel;
        }
    }
}

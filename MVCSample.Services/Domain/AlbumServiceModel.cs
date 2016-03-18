using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCSample.Core;
using MVCSample.Core.Domain;

namespace MVCSample.Services.Domain
{
    /// <summary>
    /// properties for the  AlbumServiceModel
    /// </summary>
    public class AlbumServiceModel
    {
        #region Properties

        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }

        #endregion Properties

        #region Mapper Methods

        /// <summary>
        /// Populate core entity From Service model
        /// </summary>
        public void PopulateCoreEntityFromModel(Album reqModel)
        {
            reqModel.AlbumName = AlbumName;
            reqModel.Artist = Artist;
            reqModel.Genre = Genre;
            reqModel.CreatedBy = CreatedBy;
            reqModel.DateCreated = DateCreated;
            reqModel.UpdatedBy = UpdatedBy;
            reqModel.DateUpdated = DateUpdated;
        }

        /// <summary>
        /// Populate model from core entity
        /// </summary>
        public void PopulateModelFromCoreEntity(Album reqModel)
        {
            AlbumID = reqModel.Id;
            AlbumName = reqModel.AlbumName;
            Artist = reqModel.Artist;
            Genre = reqModel.Genre;
            CreatedBy = reqModel.CreatedBy;
            DateCreated = reqModel.DateCreated;
            UpdatedBy = reqModel.UpdatedBy;
            DateUpdated = reqModel.DateUpdated;
        }

        #endregion Mapper Methods

    }
}

using MVCSample.Services;
using MVCSample.Services.Domain;
using MVCSample.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Web.Controllers
{
    public class AlbumHomeController : Controller
    {
        IAlbumService _mvcsService;
        public AlbumHomeController(IAlbumService mvcsService)
        {
            this._mvcsService = mvcsService;
        }

        public ActionResult Home()
        {
            AlbumHomeModel model = new AlbumHomeModel();
            try
            {
                List<AlbumServiceModel> allAlbums = _mvcsService.GetAlbumData();

                if (allAlbums != null && allAlbums.Count > 0)
                {
                    foreach (var album in allAlbums)
                    {
                        Album albumEntity = new Album();
                        albumEntity.AlbumID = album.AlbumID;
                        albumEntity.AlbumName = album.AlbumName;
                        albumEntity.Artist = album.Artist;
                        albumEntity.Genre = album.Genre;
                        albumEntity.CreatedBy = album.CreatedBy;
                        albumEntity.DateCreated= album.DateCreated;
                        albumEntity.UpdatedBy = album.UpdatedBy;
                        albumEntity.DateUpdated = album.DateUpdated;
                        model.Albums.Add(albumEntity);
                    }
                }
                return View(model);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
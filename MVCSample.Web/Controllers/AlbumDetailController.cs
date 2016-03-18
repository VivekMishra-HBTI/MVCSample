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
    public class AlbumDetailController : Controller
    {
        IAlbumService _mvcsService;
        public AlbumDetailController(IAlbumService mvcsService)
        {
            this._mvcsService = mvcsService;
        }

        public ActionResult AlbumDetail()
        {
            AlbumDetailModel albumModel = new AlbumDetailModel();
            try
            {
                ViewBag.CardMessage = "Album Added Successfully.";
            }
            catch (Exception e)
            {
            }
            return View(albumModel);
        }

        [HttpPost]
        public ActionResult AlbumDetail(AlbumDetailModel model)
        {
            AlbumServiceModel albumEntity = new AlbumServiceModel();
            albumEntity.AlbumName = model.AlbumName;
            albumEntity.Artist = model.Artist;
            albumEntity.Genre = model.Genre;
            albumEntity.CreatedBy = "Vivek";
            albumEntity.DateCreated = DateTime.Now;
            albumEntity.UpdatedBy = "Vivek";
            albumEntity.DateUpdated = DateTime.Now;

            _mvcsService.InsertAlbum(albumEntity);
            return RedirectToAction("Home", "AlbumHome");
        }
    }
}
using EFSandbox.Web.Models;
using EFSandbox.Web.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFSandbox.Web.Controllers
{
    public class ArtistController : Controller
    {
        //EFSandboxDbContext context = new EFSandboxDbContext();

        ArtistRepository repository = new ArtistRepository(); 

        // GET: Artist
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (!ModelState.IsValid) return View();
            repository.Add(artist);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
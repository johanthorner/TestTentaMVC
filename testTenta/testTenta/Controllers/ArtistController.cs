using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testTenta.Models;

namespace testTenta.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Artist artist1 = new Artist() {Age = 3, Band = "band1", ID = 1, Name = "Johan", Songs = new List<Song>() {new Song() {Duration = 12, Genre = "Pop", Title = "Skobbidobbi"},new Song() { Duration = 12, Genre = "Pop", Title = "wabbadabba" } } };
            Artist artist2 = new Artist() { Age = 4, Band = "band2", ID = 2, Name = "Frank", Songs = new List<Song>() { new Song() { Duration = 12, Genre = "Pop", Title = "wobbi" }, new Song() { Duration = 12, Genre = "Pop", Title = "lobbidobbi" } } };
            Artist artist3 = new Artist() { Age = 5, Band = "band3", ID = 3, Name = "Jones", Songs = new List<Song>() { new Song() { Duration = 12, Genre = "Pop", Title = "dobbi" }, new Song() { Duration = 12, Genre = "Pop", Title = "muppiduppi" } } };

            return View();
        }
    }
}
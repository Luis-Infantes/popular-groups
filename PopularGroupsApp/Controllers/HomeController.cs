using PopularGroupsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PopularGroupsApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            

            TempData["Tittle"] = "Listado de bandas";

            var bandStyle = Band.bandsCreate().OrderBy(o => o.Style).ToList();

            

            return View(bandStyle);
        }

        public ActionResult Details( int id) 
        {
            var bands = Band.bandsCreate().FirstOrDefault(p => p.Id == id);
            var concert = Concert.concertCreate().Where(w => w.BandId == id).ToList();



        ViewBag.Concert = concert;
            TempData["Tittle"] = "Detalles de la banda";


            return View(bands);
        }

        
    }
}
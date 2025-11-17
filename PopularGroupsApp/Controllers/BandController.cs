using PopularGroupsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PopularGroupsApp.Controllers
{
    public class BandController : Controller
    {
        // GET: Band
        public ActionResult Index()
        {
            var bands = Band.bandsCreate();
            var concerts = Concert.concertCreate();

            foreach (var band in bands)
            {
                band.concerts = concerts.Where(c => c.BandId == band.Id).ToList();
            }

            @TempData["Tittle"] = "Próximos conciertos";

            var orderedBands = bands.OrderBy(b => b.Style).ToList();

            return View(orderedBands);
        }


        public PartialViewResult ConcertBands(int id)
        {
            var band = Band.bandsCreate().FirstOrDefault(b => b.Id == id);
            return PartialView("ConcertBands", band);
        }






    }
}
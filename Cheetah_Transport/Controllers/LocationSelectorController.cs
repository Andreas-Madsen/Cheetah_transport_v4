using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cheetah_Transport.Data;
using Cheetah_Transport.Models;

namespace Cheetah_Transport.Controllers
{
    public class LocationSelectorController : Controller
    {
        public IActionResult LocationPage()
        {
            var locations = getLocations();
            ViewBag.startLocation = "Select start location";
            ViewBag.endLocation = "Select end location";
            return View(locations);
        }

        private List<TransportCenter> getLocations()
        {
            TransportCenterDAO dbDao = new TransportCenterDAO();
            return dbDao.FetchAll();
        }

        [HttpPost]
        public IActionResult Navigate()
        {
            //var startLocName = Request.Form["startLoc"];
            //var startLocId = Int32.Parse(Request.Form["startid"]);
            //var endLocName = Request.Form["endLoc"];
            //var endLocId = Int32.Parse(Request.Form["endid"]);
            //var start = new TransportCenter();
            //var end = new TransportCenter();
            //start.Name = startLocName;
            //start.Id = startLocId;
            //end.Name = endLocName;
            //end.Id = endLocId;

            List<TransportCenter> locations = new List<TransportCenter>();
            //locations.Add(start);
            //locations.Add(end);
            return RedirectToAction("ParcelInformationPage", "ParcelInformation", locations);
        }
    }
}
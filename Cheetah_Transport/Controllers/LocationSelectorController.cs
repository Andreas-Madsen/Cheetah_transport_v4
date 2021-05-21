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
        private List<TransportCenter> locations;

        public IActionResult LocationPage()
        {
            locations = getLocations();
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
        public IActionResult LocationPage(String startLocation)
        {
            ViewBag.startLocation = startLocation;
            return View(locations);
        }
    }
}
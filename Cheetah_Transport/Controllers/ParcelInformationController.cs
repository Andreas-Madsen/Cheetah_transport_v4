using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cheetah_Transport.Models;

namespace Cheetah_Transport.Controllers
{
    public class ParcelInformationController : Controller
    {
        public IActionResult ParcelInformationPage(List<TransportCenter> locations)
        {
            return View(locations);
        }
        [HttpPost]
        public IActionResult Navigate()
        {

           return RedirectToAction("SummaryPage", "Summary");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheetah_Transport.Controllers
{
    public class SummaryController : Controller
    {
        public IActionResult SummaryPage()
        {
            return View();
        }
    }
}

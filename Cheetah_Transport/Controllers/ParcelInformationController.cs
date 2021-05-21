using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheetah_Transport.Controllers
{
    public class ParcelInformationController : Controller
    {
        public IActionResult ParcelInformationPage()
        {
            return View();
        }
    }
}

using Cheetah_Transport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cheetah_Transport.Controllers
{
    public class FrontpageController : Controller
    {
        private readonly ILogger<FrontpageController> _logger;

        public FrontpageController(ILogger<FrontpageController> logger)
        {
            _logger = logger;
        }

            public ActionResult Start()
            {
                return View();
            }
        
    }
}

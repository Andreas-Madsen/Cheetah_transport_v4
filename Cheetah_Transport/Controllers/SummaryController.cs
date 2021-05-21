using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cheetah_Transport.Data;
using Cheetah_Transport.Models;

namespace Cheetah_Transport.Controllers
{
    public class SummaryController : Controller
    {
        public IActionResult SummaryPage()
        {
            var dao = new TransportCenterDAO();
            var t1 = dao.FetchOne(2);
            var t2 = dao.FetchOne(23);

            
            var res = Program.Engine.ComputeRoute(null, t1, t2);

            var distance = res.Item2;
            var route = res.Item1;

            
            List<string> cities = new List<string>();
            foreach (var cityId in route)
            {
                var city = dao.FetchOne(cityId);
                
                cities.Add(city.Name);
            }

            ViewBag.From = t1.Name;
            ViewBag.To = t2.Name;
            ViewBag.Distance = distance;
            ViewBag.Route = cities;



            return View();
        }
    }
}

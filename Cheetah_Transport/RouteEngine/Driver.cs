using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheetah_Transport.Data;
using Cheetah_Transport.Models;

namespace RouteEngine
{
    class Driver
    {
        static void Main(string[] args)
        {
            /*var t1 = new TransportCenter();
            t1.Name = "DARFUR";
            t1.Id = 19;

            var t2 = new TransportCenter();
            t2.Name = "ADDIS_ABEBA";
            t2.Id = 17;*/

            var dao = new TransportCenterDAO();
            var t1 = dao.FetchOne(2);
            var t2 = dao.FetchOne(23);
            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var routeEngine = new RouteEngine();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            var res = routeEngine.ComputeRoute(null, t1, t2);
            System.Console.WriteLine(elapsedMs);

            //System.Console.WriteLine(res.ToString());
            System.Console.Read();

            /*RoutesDAO routesDAO = new RoutesDAO();
            List<Routes> routes = routesDAO.FetchAll();
            foreach (var route in routes)
            {
                System.Console.WriteLine(route.Id);
                System.Console.WriteLine(route.CenterA.Name);
                System.Console.WriteLine(route.CenterB.Name);
                System.Console.WriteLine(route.TravelTime);
                System.Console.WriteLine("-----------------");
            }
            System.Console.Read();*/
        }
    }
}

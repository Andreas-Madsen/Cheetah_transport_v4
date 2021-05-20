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
            var t1 = new TransportCenter();
            t1.Name = "DARFUR";
            t1.Id = 19;

            var t2 = new TransportCenter();
            t2.Name = "ADDIS_ABEBA";
            t2.Id = 17;

            var routeEngine = new RouteEngine();
            var res = routeEngine.ComputeRoute(null, t1, t2);
            foreach (var cityId in res.Item1)
            {
                TransportCenterDAO dao = new TransportCenterDAO();
                var city = dao.FetchOne(cityId);
                System.Console.WriteLine(city.Name);
            }
            System.Console.WriteLine(res.Item2);

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

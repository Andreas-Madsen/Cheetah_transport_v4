using Cheetah_Transport.Models;
using NUnit.Framework;
using RouteEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteEngine.Tests
{
    [TestFixture()]
    public class RouteEngineTests
    {
        [Test()]
        public void RouteEngineTest()
        {
            var route = new RouteEngine();
            Assert.IsNotNull(route);
        }

        [Test()]
        public void ComputeRouteTest()
        {
            var t1 = new TransportCenter();
            t1.Name = "DARFUR";
            t1.Id = 19;
            var t2 = new TransportCenter();
            t2.Name = "ADDIS_ABEBA";
            t2.Id = 17;
            var test = new RouteEngine();
            var res = test.ComputeRoute(null, t1, t2);
            Assert.IsNotNull(res);
        }
    }
}
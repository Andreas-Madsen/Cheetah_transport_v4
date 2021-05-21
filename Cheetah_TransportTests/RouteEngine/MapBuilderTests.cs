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
    public class MapBuilderTests
    {
        [Test()]
        public void MapBuilderTest()
        {
            var test_data = new MapBuilder();
            Assert.NotNull(test_data);
        }

        [Test()]
        public void GetMapTest()
        {
            var test_data = new MapBuilder();
            test_data.GetMap();
            Assert.IsNotNull(test_data);
        }
    }
}
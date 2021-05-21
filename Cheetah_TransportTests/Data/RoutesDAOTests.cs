using NUnit.Framework;
using Cheetah_Transport.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_Transport.Data.Tests
{
    [TestFixture()]
    public class RoutesDAOTests
    {
        [Test()]
        public void FetchAllTest()
        {
            var test_data = new RoutesDAO();
            test_data.FetchAll();
            Assert.IsNotNull(test_data);
        }
    }
}
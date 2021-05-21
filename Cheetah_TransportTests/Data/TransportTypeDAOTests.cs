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
    public class TransportTypeDAOTests
    {
        [Test()]
        public void FetchAllTest()
        {
            var test_value = new TransportCenterDAO();
            test_value.FetchAll();
            Assert.NotNull(test_value);
        }

        [Test()]
        public void FetchOne()
        {
            var test_value = new TransportCenterDAO();
            test_value.FetchOne(1);
            Assert.NotNull(test_value);
        }
    }
}
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
    public class TransportCenterDAOTests
    {
        [Test()]
        public void FetchAllTest()
        {
            var test_data = new TransportCenterDAO();
            test_data.FetchAll();
            Assert.IsNotNull(test_data);
        }

        [Test()]
        public void FetchOneTest()
        {
            var test_data = new TransportCenterDAO();
            test_data.FetchOne(1);
            Assert.IsNotNull(test_data);
        }
    }
}
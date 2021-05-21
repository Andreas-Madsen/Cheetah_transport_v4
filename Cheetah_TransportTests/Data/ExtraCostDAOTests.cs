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
    public class ExtraCostDAOTests
    {
        [Test()]
        public void FecthAllTest()
        {
            var test_data = new ExtraCostDAO();
            Assert.IsNotNull(test_data);
        }
    }
}
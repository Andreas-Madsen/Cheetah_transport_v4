using NUnit.Framework;
using Cheetah_Transport.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheetah_Transport.Models;
using System.Data.SqlClient;

namespace Cheetah_Transport.Data.Tests
{
    [TestFixture()]
    public class PackageDAOTests
    {
        [Test()]
        public void FetchAllTest()
        {
            var test_data = new PackageDAO();
            test_data.FetchAll();
            if (test_data == null)
            {
                Assert.IsNull(test_data);
            }
            Assert.IsNotNull(test_data);
        }

        [Test()]
        public void CreateOneTest()
        {
            var package = new Package();
            package.ID = -1;
            package.Weight = 2.0;
            package.Height = 2.0;
            package.Length = 2.0;
            package.Weight = 2.0;
            package.RecordedPackage = 1;
            package.LiveAnimals = 1;
            package.CautiousParcel = 1;
            package.RefregiatedGoods = 1;
            var test_data = new PackageDAO();
            test_data.CreateOne(package);
            Assert.IsNotNull(test_data);
            Clean();



        }
        bool Clean()
        {
            string ConnectionString = "Data Source=tcp:dbs-tl-dk2.database.windows.net,1433;Initial Catalog=db-tl-dk2;User ID=admin-tl-dk2;Password=telStarRox16";
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sqlQuery = "DELETE FROM dbo.package WHERE Id=-1;";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            return true;
        }

        }
    }
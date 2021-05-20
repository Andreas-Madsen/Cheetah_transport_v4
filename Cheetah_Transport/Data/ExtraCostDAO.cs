using Cheetah_Transport.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Cheetah_Transport.Data
{
    public class ExtraCostDAO
    {
        private string ConnectionString = "Data Source=tcp:dbs-tl-dk2.database.windows.net,1433;Initial Catalog=db-tl-dk2;User ID=admin-tl-dk2;Password=telStarRox16";

        public List<ExtraCost> FecthAll()
        {
            List<ExtraCost> returnList = new List<ExtraCost>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sqlQuery = "SELECT * from dbo.EXTRA_COST ";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ExtraCost extracost = new ExtraCost();
                        extracost.ID = reader.GetInt32(0);
                        extracost.Type = reader.GetString(1);
                        extracost.Fee = reader.GetDouble(2);
                        extracost.PackageID = reader.GetInt32(3);
                       
                        returnList.Add(extracost);
                    }
                }

            }
            return returnList;
        }

    }
}
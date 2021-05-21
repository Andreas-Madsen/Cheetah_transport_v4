using ExternalIntegration.Controllers;
using ExternalIntegration.Enums;
using ExternalIntegration.Models;
using ExternalIntegration.Services;
using ExternalIntegration.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading;

namespace ExternalIntegration
{
    public class DataObject {
        public string Name { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            TelstarCommunication.RequestRoute(new TelstarRequest {
                Company = CompanyEnum.TELSTAR_LOGISTICS.ToString(),
                SecretCompanyCode = CompanySecrets.GetTelstarSecret(),
                CityFrom = CityEnum.ADDIS_ABEBA.ToString(),
                CityTo = CityEnum.CAIRO.ToString(),
                Features = new string[0],
                Weight = 2,
                Height = 2,
                Width = 2,
                Length = 2
            });

            OceanicResponse oceanicResponse = OceanicAirlinesCommunication.RequestRoute(CompanyEnum.TELSTAR_LOGISTICS, CityEnum.ADDIS_ABEBA, CityEnum.AMATAVE, "parcelType", 2, 3, 4, 5);
            EastIndiaResponse eastIndiaResponse  = EastIndiaTradingCommunication.RequestRoute(CityEnum.KAP_GUARDAFUI, CityEnum.SUAKIN, 50, false, false);
            */
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

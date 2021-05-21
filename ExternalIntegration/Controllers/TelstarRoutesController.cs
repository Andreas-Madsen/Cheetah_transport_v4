using ExternalIntegration.Enums;
using ExternalIntegration.Validations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace ExternalIntegration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelstarRoutesController : ControllerBase
    {
        private readonly ILogger<TelstarRoutesController> _logger;

        public TelstarRoutesController(ILogger<TelstarRoutesController> logger)
        {
            _logger = logger;
        }

        private TelstarResponse returnError(string errorMsg) 
        {
            return new TelstarResponse {
                price = -1,
                time = -1,
                error = errorMsg
            };
        }

        public static int GetPrice(TelstarRequest telstarRequest) {
            double price = 100;
            
            if(telstarRequest.Company == CompanyEnum.EAST_INDIA_TRADING.ToString()) {
                price = price * 0.90;
            } else if (telstarRequest.Company == CompanyEnum.OCEANIC_AIRLINES.ToString()) {
                price = price * 1.05;
            }

            foreach(string feature in telstarRequest.Features) {
                if(feature.Equals(FeatureEnum.RECOMMENDED.ToString())) {
                    price += 10;
                }
                
                if (feature.Equals(FeatureEnum.LIVE_ANIMALS.ToString())) {
                    price = price * 1.5;
                }

                if (feature.Equals(FeatureEnum.CAUTIOUSLY.ToString())) {
                    price = price * 1.75;
                }

                if (feature.Equals(FeatureEnum.REFIGERATED.ToString())) {
                    price = price * 1.10;
                }
            }

            return (int) price;
        }

        private int GetTime(TelstarRequest telstarRequest) {
            int time = 100;

            //TODO implement
            return time;
        }


        [HttpGet]
        public TelstarResponse Get([FromBody] TelstarRequest telstarRequest) 
        {
            string errorMsg = CommunicationValidation.VerifyTelstarRequest(telstarRequest);
            if (errorMsg != null) {
                return returnError(errorMsg);
            }

            return new TelstarResponse {
                price = GetPrice(telstarRequest),
                time = GetTime(telstarRequest),
                error = "NO_ERROR"
            };
        }
    }
}

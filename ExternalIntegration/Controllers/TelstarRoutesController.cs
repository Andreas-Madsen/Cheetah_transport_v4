using Cheetah_Transport.Data;
using Cheetah_Transport.Models;
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

        public static int GetPrice(TelstarRequest telstarRequest, int originalPrice) {
            double price = originalPrice;
            
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

        private int GetId(string city) {

            if(city.Equals(CityEnum.TUNIS.ToString())) {
                return 1;
            } else if (city.Equals(CityEnum.TANGER.ToString())) {
                return 2;
            } else if (city.Equals(CityEnum.MARRAKESH.ToString())) {
                return 3;
            } else if (city.Equals(CityEnum.DAKAR.ToString())) {
                return 4;
            } else if (city.Equals(CityEnum.SIERRA_LEONE.ToString())) {
                return 5;
            } else if (city.Equals(CityEnum.TIMBUKTU.ToString())) {
                return 6;
            } else if (city.Equals(CityEnum.SLAVEKYSTEN.ToString())) {
                return 7;
            } else if (city.Equals(CityEnum.WADAI.ToString())) {
                return 8;
            } else if (city.Equals(CityEnum.CONGO.ToString())) {
                return 9;
            } else if (city.Equals(CityEnum.LUANDA.ToString())) {
                return 10;
            } else if (city.Equals(CityEnum.MOCAMBIQUE.ToString())) {
                return 11;
            } else if (city.Equals(CityEnum.VICTORIASOEEN.ToString())) {
                return 12;
            }  else if (city.Equals(CityEnum.HVALBUGTEN.ToString())) {
                return 13;
            } else if (city.Equals(CityEnum.ZANZIBAR.ToString())) {
                return 14;
            } else if (city.Equals(CityEnum.KABALO.ToString())) {
                return 15;
            }
            else if (city.Equals(CityEnum.VICTORIASOEEN.ToString())) {
                return 16;
            }
            else if (city.Equals(CityEnum.ADDIS_ABEBA.ToString())) {
                return 17;
            }
            else if (city.Equals(CityEnum.SUAKIN.ToString())) {
                return 18;
            }
            else if (city.Equals(CityEnum.DARFUR.ToString())) {
                return 19;
            }
            else if (city.Equals(CityEnum.OMDURMAN.ToString())) {
                return 20;
            }
            else if (city.Equals(CityEnum.SAHARA.ToString())) {
                return 21;
            }
            else if (city.Equals(CityEnum.TRIPOLI.ToString())) {
                return 22;
            }
            else if (city.Equals(CityEnum.BAHR_EL_GHAZAL.ToString())) {
                return 23;
            }
            else if (city.Equals(CityEnum.GULDKYSTEN.ToString())) {
                return 24;
            }
            else if (city.Equals(CityEnum.DRAGEBJERGET.ToString())) {
                return 25;
            }
            else if (city.Equals(CityEnum.KAPSTADEN.ToString())) {
                return 26;
            }
            else if (city.Equals(CityEnum.KAP_GUARDAFUI.ToString())) {
                return 27;
            }
            else if (city.Equals(CityEnum.CAIRO.ToString())) {
                return 28;
            }
            else if (city.Equals(CityEnum.AMATAVE.ToString())) {
                return 29;
            }
            else if (city.Equals(CityEnum.KAP_ST_MARIE.ToString())) {
                return 30;
            }
            else if (city.Equals(CityEnum.ST_HELENA.ToString())) {
                return 31;
            }
            else if (city.Equals(CityEnum.DE_KANARISKE_OER.ToString())) {
                return 32;
            }

            return -1;
        }

        [HttpGet]
        public TelstarResponse Get([FromBody] TelstarRequest telstarRequest) 
        {
            string errorMsg = CommunicationValidation.VerifyTelstarRequest(telstarRequest);
            if (errorMsg != null) {
                return returnError(errorMsg);
            }

            RoutesDAO routesDAO = new RoutesDAO();
            Routes routes = routesDAO.FetchOne(GetId(telstarRequest.CityTo), GetId(telstarRequest.CityFrom));

            return new TelstarResponse {
                price = GetPrice(telstarRequest, routes.Price),
                time = routes.TravelTime,
                error = "NO_ERROR"
            };
        }
    }
}

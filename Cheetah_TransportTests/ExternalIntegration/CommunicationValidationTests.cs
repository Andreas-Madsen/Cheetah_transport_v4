using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExternalIntegration.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalIntegration.Enums;
using ExternalIntegration.Utils;

namespace ExternalIntegration.Validations.Tests {
    [TestClass()]
    public class CommunicationValidationTests {
        private void IsError(string s) {
            Assert.IsNotNull(s);
        }

        private void NoError(string s) {
            Assert.IsNull(s);
        }

        [TestMethod()]
        public void CitiesNotConnect() {
            string s = CommunicationValidation.IsCitiesDirect(CityEnum.SUAKIN, CityEnum.TANGER);
            IsError(s);
        }

        [TestMethod()]
        public void CitiesConnect() {
            string s = CommunicationValidation.IsCitiesDirect(CityEnum.TUNIS, CityEnum.TANGER);
            NoError(s);
        }

        [TestMethod()]
        public void CitiesConnectInvert() {
            string s = CommunicationValidation.IsCitiesDirect(CityEnum.TANGER, CityEnum.TUNIS);
            NoError(s);
        }

        [TestMethod()]
        public void InvalidCompanySecret() {
            string s = CommunicationValidation.IsCompanySecretValid(CompanyEnum.OCEANIC_AIRLINES, CompanySecrets.GetIndiaSecret());
            IsError(s);
        }

        [TestMethod()]
        public void ValidCompanySecret() {
            string s = CommunicationValidation.IsCompanySecretValid(CompanyEnum.EAST_INDIA_TRADING, CompanySecrets.GetIndiaSecret());
            NoError(s);
        }

        [TestMethod()]
        public void InvalidNr() {
            string s = CommunicationValidation.IsNumberValid(-2);
            IsError(s);
        }

        [TestMethod()]
        public void ValidNr() {
            string s = CommunicationValidation.IsNumberValid(2);
            NoError(s);
        }

        [TestMethod()]
        public void ValidateRequest() {
            string s = CommunicationValidation.VerifyTelstarRequest(new TelstarRequest {
                Company = CompanyEnum.TELSTAR_LOGISTICS.ToString(),
                SecretCompanyCode = CompanySecrets.GetTelstarSecret(),
                CityFrom = CityEnum.KAPSTADEN.ToString(),
                CityTo = CityEnum.HVALBUGTEN.ToString(),
                Features = new string[0],
                Height = 2,
                Length = 2,
                Width = 2,
                Weight = 2
            });
            NoError(s);
        }

        [TestMethod()]
        public void WeaponNotAllowed() {
            string s = CommunicationValidation.VerifyTelstarRequest(new TelstarRequest {
                Company = CompanyEnum.TELSTAR_LOGISTICS.ToString(),
                SecretCompanyCode = CompanySecrets.GetTelstarSecret(),
                CityFrom = CityEnum.KAPSTADEN.ToString(),
                CityTo = CityEnum.HVALBUGTEN.ToString(),
                Features = new string[] { FeatureEnum.WEAPONS.ToString()},
                Height = 2,
                Length = 2,
                Width = 2,
                Weight = 2
            });
            IsError(s);
        }

        [TestMethod()]
        public void InvalidValue() {
            string s = CommunicationValidation.VerifyTelstarRequest(new TelstarRequest {
                Company = CompanyEnum.TELSTAR_LOGISTICS.ToString(),
                SecretCompanyCode = CompanySecrets.GetTelstarSecret(),
                CityFrom = CityEnum.KAPSTADEN.ToString(),
                CityTo = CityEnum.HVALBUGTEN.ToString(),
                Features = new string[0],
                Height = 2,
                Length = 2,
                Width = -2,
                Weight = 2
            });
            IsError(s);
        }
    }
}
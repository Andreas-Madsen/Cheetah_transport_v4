using ExternalIntegration.Enums;
using ExternalIntegration.Utils;
using System;
using System.Collections.Generic;

namespace ExternalIntegration.Validations {
    public class CommunicationValidation {
        /**
         * Check that the company secret is valid
         */
        public static string IsCompanySecretValid(CompanyEnum company, string secret)
        {
            switch (company) 
            {
                case CompanyEnum.OCEANIC_AIRLINES:
                    if (!secret.Equals(CompanySecrets.GetOceanicSecret())) {
                        return "Invalid secret";
                    }
                    break;
                case CompanyEnum.EAST_INDIA_TRADING:
                    if (!secret.Equals(CompanySecrets.GetIndiaSecret())) {
                        return "Invalid secret";
                    }
                    break;
                case CompanyEnum.TELSTAR_LOGISTICS:
                    if (!secret.Equals(CompanySecrets.GetTelstarSecret())) {
                        return "Invalid secret";
                    }
                    break;
            }
            return null;
        }

        private static bool checkCites(CityEnum c1, CityEnum c2, CityEnum c3) {
            return c1 == c3 || c2 == c3;
        }

        /**
         * Check that the cities are directly connected. Returns null if
         * the cities are directly connected
         * 
         * Insanely "good" and "short" method
         */
        public static string IsCitiesDirect(CityEnum cityFrom, CityEnum cityTo) 
        {
            if(checkCites(cityFrom, cityTo, CityEnum.TANGER)) {
                if(checkCites(cityFrom, cityTo, CityEnum.MARRAKESH)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.TUNIS)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.SAHARA)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.TUNIS)) {
                if (checkCites(cityFrom, cityTo, CityEnum.TRIPOLI)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.TRIPOLI)) {
                if (checkCites(cityFrom, cityTo, CityEnum.OMDURMAN)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.OMDURMAN)) {
                if (checkCites(cityFrom, cityTo, CityEnum.CAIRO)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.DARFUR)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.SUAKIN)) {
                if (checkCites(cityFrom, cityTo, CityEnum.DARFUR)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.ADDIS_ABEBA)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.ADDIS_ABEBA)) {
                if (checkCites(cityFrom, cityTo, CityEnum.KAP_GUARDAFUI)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.VICTORIASOEEN)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.KAP_GUARDAFUI)) {
                if (checkCites(cityFrom, cityTo, CityEnum.ZANZIBAR)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.ZANZIBAR)) {
                if (checkCites(cityFrom, cityTo, CityEnum.MOCAMBIQUE)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.VICTORIASOEEN)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.MOCAMBIQUE)) {
                if (checkCites(cityFrom, cityTo, CityEnum.DRAGEBJERGET)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.VICTORIA_FALDENE)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.LUANDA)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.DRAGEBJERGET)) {
                if (checkCites(cityFrom, cityTo, CityEnum.VICTORIA_FALDENE)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.VICTORIA_FALDENE)) {
                if (checkCites(cityFrom, cityTo, CityEnum.HVALBUGTEN)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.HVALBUGTEN)) {
                if (checkCites(cityFrom, cityTo, CityEnum.KAPSTADEN)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.LUANDA)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.LUANDA)) {
                if (checkCites(cityFrom, cityTo, CityEnum.CONGO)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.KABALO)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.CONGO)) {
                if (checkCites(cityFrom, cityTo, CityEnum.SLAVEKYSTEN)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.WADAI)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.DARFUR)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.SLAVEKYSTEN)) {
                if (checkCites(cityFrom, cityTo, CityEnum.TIMBUKTU)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.WADAI)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.DARFUR)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.TIMBUKTU)) {
                if (checkCites(cityFrom, cityTo, CityEnum.GULDKYSTEN)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.GULDKYSTEN)) {
                if (checkCites(cityFrom, cityTo, CityEnum.SIERRA_LEONE)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.TIMBUKTU)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.DAKAR)) {
                if (checkCites(cityFrom, cityTo, CityEnum.MARRAKESH)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.MARRAKESH)) {
                if (checkCites(cityFrom, cityTo, CityEnum.SAHARA)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.SAHARA)) {
                if (checkCites(cityFrom, cityTo, CityEnum.DAKAR)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.DARFUR)) {
                if (checkCites(cityFrom, cityTo, CityEnum.WADAI)) {
                    return null;
                }

                if (checkCites(cityFrom, cityTo, CityEnum.BAHR_EL_GHAZAL)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.BAHR_EL_GHAZAL)) {
                if (checkCites(cityFrom, cityTo, CityEnum.VICTORIASOEEN)) {
                    return null;
                }
            }

            if (checkCites(cityFrom, cityTo, CityEnum.VICTORIASOEEN)) {
                if (checkCites(cityFrom, cityTo, CityEnum.KABALO)) {
                    return null;
                }
            }

            return "City is not direct";
        }

        /**
         * Checks that the number is valid
         */
        public static string IsNumberValid(int i) {
            if(i > 0)
            {
                return null;
            }
            return "Invalid value: " + i;
        }

        /**
         * Validates the request for telstar logistics
         */
        public static string VerifyTelstarRequest(TelstarRequest telstarRequest) 
        {
            //Check company
            CompanyEnum company;
            try 
            {
                company = (CompanyEnum)Enum.Parse(typeof(CompanyEnum), telstarRequest.Company);
            }
            catch (Exception) 
            {
                return "Invalid company";
            }

            //Check company secret
            string secretError = IsCompanySecretValid(company, telstarRequest.SecretCompanyCode);
            if(secretError != null) 
            {
                return secretError;
            }
            
            //Check valid cities
            CityEnum cityFrom;
            CityEnum cityTo;
            try 
            {
                cityFrom = (CityEnum)Enum.Parse(typeof(CityEnum), telstarRequest.CityFrom);
                cityTo = (CityEnum)Enum.Parse(typeof(CityEnum), telstarRequest.CityTo);
            } 
            catch (Exception) 
            {
                return "Invalid city";
            }

            //Check identical cities
            if(cityFrom == cityTo)
            {
                return "CityFrom cannot be equal to CityTo";
            }

            //Check if cities are directly connected
            string citiesDirectError = IsCitiesDirect(cityFrom, cityTo);
            if (citiesDirectError != null)
            {
                return citiesDirectError;
            }

            //Check weight
            string weightError = IsNumberValid(telstarRequest.Weight);
            if (weightError != null) {
                return weightError;
            }

            if(telstarRequest.Weight > 40) {
                return "Weight cannot be more than 40";
            }

            //Check width
            string widthError = IsNumberValid(telstarRequest.Width);
            if (widthError != null) {
                return widthError;
            }

            //Check length
            string lengthError = IsNumberValid(telstarRequest.Length);
            if (lengthError != null) {
                return lengthError;
            }

            //Check height
            string heightError = IsNumberValid(telstarRequest.Height);
            if(heightError != null) {
                return heightError;
            }

            //Check features
            List<FeatureEnum> features = new List<FeatureEnum>();
            bool refSeen = false;
            bool animalSeen = false;
            bool cautioslySeen = false;
            string errorMsg = "Cannot transport refrigerated, animals and cautiosly in one delivery";
            foreach (string feature in telstarRequest.Features) {
                try {
                    FeatureEnum f = (FeatureEnum)Enum.Parse(typeof(FeatureEnum), feature);
                    features.Add(f);
                    if (f == FeatureEnum.WEAPONS) {
                        return "Weapons are not allowed";
                    }
                    
                    if (f == FeatureEnum.REFIGERATED) {
                        refSeen = true;
                        if(animalSeen || cautioslySeen) {
                            return errorMsg;
                        }
                    }

                    if (f == FeatureEnum.LIVE_ANIMALS) {
                        animalSeen = true;
                        if (refSeen || cautioslySeen) {
                            return errorMsg;
                        }
                    }

                    if (f == FeatureEnum.CAUTIOUSLY) {
                        cautioslySeen = true;
                        if (animalSeen || refSeen) {
                            return errorMsg;
                        }
                    }
                }
                catch (Exception) {
                    return "Invalid feature: " + feature;
                }
            }
            
            return null;
        }
    }
}

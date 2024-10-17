using ElevApiHelper.Util;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevApiTest.Util
{
    public static class ElevConfigHelper
    {
        public static ElevConfig GetElevConfig()
        {
            IConfigurationRoot? configurationRoot = GetConfigurationRoot();

            string uriString = !string.IsNullOrWhiteSpace(configurationRoot.GetValue<string?>("ElevAcsses:BaseAddres")) ?
            configurationRoot.GetValue<string>("ElevAcsses:BaseAddres")! :
            "";

            string apiKeyStirng = !string.IsNullOrWhiteSpace(configurationRoot.GetValue<string?>("ElevAcsses:Userstring")) ?
            configurationRoot.GetValue<string>("ElevAcsses:Userstring")! :
            "";

            ElevConfig config = new ElevConfig()
            {
                Uri = new Uri(uriString),
                ApiKey = apiKeyStirng
            };
            return config;
        }

        private static IConfigurationRoot GetConfigurationRoot()
        {
            IConfigurationBuilder configuration = new ConfigurationBuilder().AddJsonFile("C:\\ElevApiHelper\\ElevApiTest\\appsettings.json");
            IConfigurationRoot configurationRoot = configuration.Build();
            return configurationRoot;
        }
    }
}

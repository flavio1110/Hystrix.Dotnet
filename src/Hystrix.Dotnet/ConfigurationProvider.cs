using System;
#if !COREFX
using System.Configuration;
#endif
#if COREFX
using Microsoft.Extensions.Configuration;
#endif


namespace Hystrix.Dotnet
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        #if !COREFX
        public string GetSetting(string configKey)
        {
            return ConfigurationManager.AppSettings[configKey];
        }
        #endif

        #if COREFX

        private readonly IConfigurationSection appSettings;
        public ConfigurationProvider(IConfigurationRoot configurationRoot)
        {
            if(configurationRoot == null)
            {
                throw new ArgumentNullException(nameof(configurationRoot));
            }

            appSettings = configurationRoot.GetSection("AppSettings");
        }
        public string GetSetting(string configKey)
        {
            return appSettings.GetValue<string>(configKey);
        }
        #endif
    }
}
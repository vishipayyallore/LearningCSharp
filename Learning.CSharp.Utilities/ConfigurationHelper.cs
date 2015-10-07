using System.Configuration;

namespace Learning.CSharp.Utilities
{

    public class ConfigurationHelper
    {
        #region Methdos.
        public static string GetConfigurationValue(string configurationItemKey)
        {
            return ConfigurationManager.AppSettings[configurationItemKey] ?? string.Empty;
        }
        #endregion
    }

}

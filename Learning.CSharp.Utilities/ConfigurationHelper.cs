using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

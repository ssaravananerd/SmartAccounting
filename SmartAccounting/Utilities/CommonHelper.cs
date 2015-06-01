using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class CommonHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["ConnectionString"];
        }

        public static string GetAppSettings(string key)
        {
            if (String.IsNullOrEmpty(key))
                throw new ArgumentNullException("Argument key should not a null");
            return ConfigurationManager.AppSettings[key];
        }
    }
}

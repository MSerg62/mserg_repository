using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BusinessRules.Utils
{
    public class ConfigValues
    {
       
        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";               
            }
            catch (ConfigurationErrorsException)
            {
               /// Console.WriteLine("Error reading app settings");
            }
        }
        public static string CisdbConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["cisdb"].ToString();
            }
        }

    }
}

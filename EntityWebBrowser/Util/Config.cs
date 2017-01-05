using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityWebBrowser.Util;

namespace EntityWebBrowser.Util
{
    public class Config
    {
        private static ExeConfigurationFileMap ConfigFileMap = null;
        private static Configuration config = null;

        public static void UpdateAppConfig(string newKey, string newValue)
        {
            if (config == null) IniConfiguration();
            config.AppSettings.Settings[newKey].Value = newValue;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string ReadAppConfig(string Key)
        {
            string result = "";
            try
            {
                if (config == null) IniConfiguration();
                result = config.AppSettings.Settings[Key].Value;
            }
            catch (Exception)
            { }
            return result;
        }

        private static string GetConfigFile()
        {
            return Application.ExecutablePath + ".Config";
        }

        private static void IniConfiguration()
        {
            ConfigFileMap = new ExeConfigurationFileMap();
            ConfigFileMap.ExeConfigFilename = GetConfigFile();
            config = ConfigurationManager.OpenMappedExeConfiguration(ConfigFileMap, ConfigurationUserLevel.None);
        }

    }
}

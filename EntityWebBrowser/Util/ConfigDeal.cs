using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace EntityWebBrowser.Util
{
    class ConfigDeal
    {
        /// <summary>
        /// 读取appSetting
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static  string  AppSetRead(string keyName)
        {
            return ConfigurationManager.AppSettings[keyName];
        }
        /// <summary>
        /// 更新appSetting
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="value"></param>
        public static void AppSetWrite(string keyName, string value)
        {
            bool isExist = false;
            if (ConfigurationManager.AppSettings[keyName] != null)
            {
                isExist = true;
            }
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if(isExist) config.AppSettings.Settings.Remove(keyName);
            config.AppSettings.Settings.Add(keyName,value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        /// <summary>
        /// 读取连接字符串
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static string  ConnectionRead(string Name)
        {
            return ConfigurationManager.ConnectionStrings[Name].ConnectionString.ToString();
        }
        /// <summary>
        /// 更新连接字符串
        /// </summary>
        /// <param name="name"></param>
        /// <param name="connStr"></param>
        /// <param name="provider"></param>
        public static void ConnectionWrite(string name, string connStr, string provider)
        {
            bool isExist = false;
            if (ConfigurationManager.ConnectionStrings[name] != null)
            {
                isExist = true;
            }
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings mySettings =
            new ConnectionStringSettings(name,connStr,provider);   
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}

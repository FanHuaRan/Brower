using EntityWebBrowser.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.Services.Impl
{
    /// <summary>
    /// 配置文件服务实现
    /// </summary>
    class HomeUrlServiceClass:IHomeUrlService
    {

        public string GetHomeUrl()
        {
            return Config.ReadAppConfig("HomeUrl");
        }

        public void UpdateHomeUrl(string url)
        {
            ////写到TXT文档中
            //HomeUrlClass.SetHomeUrl(string.Format("{0}\\HomeUrl.txt", Application.StartupPath),
            //    this.webBrowser1.Url.ToString());
            //改写配置文件
            Config.UpdateAppConfig("HomeUrl", url);
        }
    }
}

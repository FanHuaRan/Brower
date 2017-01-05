using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.Services
{
    /// <summary>
    /// 配置文件操作接口
    /// </summary>
    interface IHomeUrlService
    {
        string GetHomeUrl();
        void UpdateHomeUrl(string url);
    }
}

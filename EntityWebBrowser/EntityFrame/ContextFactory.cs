using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.EntityFrame
{
    /// <summary>
    /// 实体框架上下文工厂
    /// 2016/12/26 fhr
    /// </summary>
    class ContextFactory
    {
        private static MyContext context = null;
        public static MyContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new MyContext();
                }
                return context;
            }
        }
    }
}

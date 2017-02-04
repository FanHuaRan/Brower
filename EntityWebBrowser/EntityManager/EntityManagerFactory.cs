using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.EntityManager
{
    /// <summary>
    /// 实体访问类静态工厂
    /// 2016/12/30 fhr 
    /// </summary>
    class EntityManagerFactory
    {
        public static RecordManager RecordManager
        {
            get
            {
               return RecordManager.Instance;
            }
        }
        public static BookMarkManager BookMarkManager
        {
            get
            {
                return BookMarkManager.Instance;
            }
        }
        public static CatalogManager CatalogManager
        {
            get
            {
                return CatalogManager.Instance;
            }
        }
    }
}

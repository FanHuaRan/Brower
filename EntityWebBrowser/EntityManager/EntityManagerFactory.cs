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
        private static RecordManager recordManager = null;
        public static RecordManager RecordManager
        {
            get
            {
                if (recordManager == null)
                {
                    recordManager = new RecordManager();
                }
                return recordManager;
            }
        }
        private static BookMarkManager bookMarkManager = null;
        public static BookMarkManager BookMarkManager
        {
            get
            {
                if (bookMarkManager == null)
                {
                    bookMarkManager = new BookMarkManager();
                }
                return bookMarkManager;
            }
        }
        private static CatalogManager catalogManager = null;
        public static CatalogManager CatalogManager
        {
            get
            {
                if (catalogManager == null)
                {
                    catalogManager = new CatalogManager();
                }
                return catalogManager;
            }
        }
    }
}

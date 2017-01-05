using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityWebBrowser.EntityManager;
using EntityWebBrowser.Services.Impl;
namespace EntityWebBrowser.Services
{
    /// <summary>
    /// 服务静态工厂  
    /// 2016/12/30 fhr
    /// </summary>
    class ServicesFactory
    {
        private static IBookMarkService bookmarkService;
        public static IBookMarkService BookmarkService
        {
            get
            {

                if (bookmarkService == null)
                {
                    bookmarkService = new BookmarkServiceClass(EntityManagerFactory.BookMarkManager, EntityManagerFactory.CatalogManager);
                }
                return bookmarkService;
            }
        }

        private static IRecordService recordService;
        public static IRecordService RecordService
        {
            get
            {

                if (recordService == null)
                {
                    recordService = new RecordServiceClass(EntityManagerFactory.RecordManager);
                }
                return recordService;
            }
        }

        private static IHomeUrlService homeUrlService;
        public static IHomeUrlService HomeUrlService
        {
            get
            {
                if (homeUrlService == null)
                {
                    homeUrlService = new HomeUrlServiceClass();
                }
                return homeUrlService;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF.EntityManager;
namespace TestEF.Services
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
    }
}

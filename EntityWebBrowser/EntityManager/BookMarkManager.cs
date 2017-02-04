using EntityWebBrowser.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.EntityManager
{
    /// <summary>
    /// 书签访问管理类
    /// 2016/12/26 fhr
    /// </summary>
    class BookMarkManager : EntityBaseService<BookMark>, IEntityService<BookMark>
    {
        public IList<BookMark> FindByCatalog(Int64 catalogId)
        {
            return context.BookMarks.Where(p => p.CatalogID == catalogId).ToList<BookMark>();
        }
        //C#值类型后面加问号表示可为空null(Nullable 结构)
        public IList<IGrouping<Int64?, BookMark>> FindByGroup()
        {
            //return context.BookMarks.GroupBy(p => p.CatalogID).ToList() as IList<IGrouping<int, BookMark>>;
            List<IGrouping<Int64?, BookMark>> bookMarks = context.BookMarks.GroupBy(p => p.CatalogID).ToList();
            return bookMarks as IList<IGrouping<Int64?, BookMark>>;
        }
        public IList<BookMark> FindByTitle(string title)
        {
            return context.BookMarks.Where(p => p.Title == title).ToList<BookMark>();
        }
        private BookMarkManager()
            : base()
        {

        }
        private static BookMarkManager instance = null;
        public static BookMarkManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookMarkManager();
                }
                return instance;
            }
        }
    }
}

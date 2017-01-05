using EntityWebBrowser.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.Services
{
    /// <summary>
    /// 书签相关服务
    /// 2016/12/30 fhr
    /// </summary>
    interface IBookMarkService
    {
        IList<IGrouping<Int64?, BookMark>> FindBookMarksGroup();
        IList<BookMark> FindBookMarks();
        IList<Catalog> FindCatalogs();

        BookMark InsertBookMark(BookMark bookMark);

        bool UpdateBookMark(BookMark bookMark);

        void DeleteBookMark(Int64 id);

        void DeleteBookMarksByCatalog(Int64 catalogId);

        void DeleteBookMarkByTitle(string titile);
        void DeleteCatalogByName(string name);
        Catalog InsertCatalog(Catalog catalog);

        bool UpdateCatalog(Catalog catalog);

        void DeleteCatalog(Int64 id);
        IList<BookMark> FindBookMarkByTitle(string title);
    }
}

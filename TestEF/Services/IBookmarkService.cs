using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.Services
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

        bool InsertBookMark(BookMark bookMark);

        bool UpdateBookMark(BookMark bookMark);

        void DeleteBookMark(Int64 id);

        void DeleteBookMarksByCatalog(Int64 catalogId);

        bool InsertCatalog(Catalog catalog);

        bool UpdateCatalog(Catalog catalog);

        void DeleteCatalog(Int64 id);
    }
}

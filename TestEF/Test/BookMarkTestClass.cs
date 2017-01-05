using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF.Services;
namespace TestEF.Test
{
    class BookMarkTestClass
    {
        private static IBookMarkService bookMarkService = ServicesFactory.BookmarkService;
        public static void TestGetBookMarks()
        {
            List<BookMark> bookMarks = bookMarkService.FindBookMarks() as List<BookMark>;
            bookMarks.ForEach(p => { Console.WriteLine("{0} {1} {2}", p.BookMarkID, p.Url, p.Title); });
        }
        public static void TestGeCatalogs()
        {
            List<Catalog> catalogs = bookMarkService.FindCatalogs() as List<Catalog>;
            catalogs.ForEach(p => { Console.WriteLine("{0} {1}", p.CatalogID, p.CatalogName); });
        }
        public static void TestGetCatalogsGroupe()
        {
            List<IGrouping<Int64?, BookMark>> catalogs = bookMarkService.FindBookMarksGroup() as List<IGrouping<Int64?, BookMark>>;
            catalogs.ForEach(p =>
            {
                Console.WriteLine(p.Key);
                foreach (var bookmark in p)
                {
                    Console.WriteLine("{0} {1} {2}", bookmark.BookMarkID, bookmark.Title,bookmark.Url);
                }
            });
        }
        public static void TestUpdateCatalog()
        {
            Catalog catalog = new Catalog(1, "电影2");
            Console.WriteLine(bookMarkService.UpdateCatalog(catalog));
        }
        public static void TestUpdateBookMark()
        {
            BookMark bookMark = new BookMark(1, "htt", "My", null);
            Console.WriteLine(bookMarkService.UpdateBookMark(bookMark));
        }
        public static void TestInsertCatalog()
        {
            Catalog catalog = new Catalog();
            catalog.CatalogName = "测试条目";
            Console.WriteLine(bookMarkService.InsertCatalog(catalog));
        }
        public static void TestInsertBookmark()
        {
            BookMark bookMark = new BookMark("htt2", "My2", null);
            Console.WriteLine(bookMarkService.InsertBookMark(bookMark));
            Console.WriteLine("插入Bookmark成功");
        }
        public static void TestDeleteCatalog()
        {
            bookMarkService.DeleteCatalog(10);
            Console.WriteLine("删除catalog成功");
        }
        public static void TestDeleteBookmark()
        {
            bookMarkService.DeleteBookMark(3);
            Console.WriteLine("删除Bookmark成功");
        }
    }
}

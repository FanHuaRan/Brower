using EntityWebBrowser.Entity;
using EntityWebBrowser.EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.Services.Impl
{
    /// <summary>
    /// 书签服务实现类
    /// </summary>
    class BookmarkServiceClass:IBookMarkService
    {
        private BookMarkManager bookMarkManager;
        private CatalogManager catalogManager;
        public BookmarkServiceClass(BookMarkManager bookMarkManager, CatalogManager catalogManager)
        {
            this.bookMarkManager = bookMarkManager;
            this.catalogManager = catalogManager;
        }
        public IList<BookMark> FindBookMarks()
        {
            return bookMarkManager.FindAll();
        }

        public IList<Catalog> FindCatalogs()
        {
            return catalogManager.FindAll();
        }

        public BookMark InsertBookMark(BookMark bookMark)
        {
            return bookMarkManager.Insert(bookMark);
        }

        public bool UpdateBookMark(BookMark bookMark)
        {
            if (bookMarkManager.Update(bookMark) != null)
            {
                return true;
            }
            else return false;
        }

        public void DeleteBookMark(long id)
        {
            List<BookMark> bookMarks = this.bookMarkManager.FindAll() as List<BookMark>;
            bookMarks.ForEach(p =>
            {
                this.bookMarkManager.DeleteById(p.BookMarkID);
            });
        }

        public void DeleteBookMarksByCatalog(long catalogId)
        {
            List<BookMark> bookMarks = bookMarkManager.FindByCatalog(catalogId) as List<BookMark>;
            bookMarks.ForEach(p =>
            {
                this.bookMarkManager.DeleteById(p.BookMarkID);
            });
        }

        public Catalog InsertCatalog(Catalog catalog)
        {
            return catalogManager.Insert(catalog);
        }

        public bool UpdateCatalog(Catalog catalog)
        {
            if (this.catalogManager.Update(catalog) != null)
            {
                return true;
            }
            else return false;
        }

        public void DeleteCatalog(long id)
        {
            DeleteBookMarksByCatalog(id);
            this.catalogManager.DeleteById(id);
        }

        public IList<IGrouping<Int64?, BookMark>> FindBookMarksGroup()
        {
            return bookMarkManager.FindByGroup();
        }


        public void DeleteBookMarkByTitle(string title)
        {
          var bookmarks=  bookMarkManager.FindByTitle(title);
          foreach (var bookmark in bookmarks)
          {
              this.DeleteBookMark(bookmark.BookMarkID);
          }
        }

        public void DeleteCatalogByName(string name)
        {
            var catalogs = catalogManager.FindByName(name);
            foreach (var catalog in catalogs)
            {
                this.DeleteCatalog(catalog.CatalogID);
            }
        }

        public IList<BookMark> FindBookMarkByTitle(string title)
        {
            return bookMarkManager.FindByTitle(title);
        }
    }
}

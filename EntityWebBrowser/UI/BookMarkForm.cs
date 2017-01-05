using EntityWebBrowser.Entity;
using EntityWebBrowser.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace EntityWebBrowser
{
    public partial class BookMarkForm : Form
    {
        private IBookMarkService bookMarkService = null;
        private List<Catalog> catalogs; 
        public BookMarkForm()
        {
            InitializeComponent();
            bookMarkService = ServicesFactory.BookmarkService;
            catalogs = bookMarkService.FindBookMarks() as List<Catalog>;
            this.StartPosition=FormStartPosition.CenterScreen;
        }
        public BookMarkForm(string catalog,string title,string url)
        {
            InitializeComponent();
            bookMarkService = ServicesFactory.BookmarkService;
            catalogs = bookMarkService.FindBookMarks() as List<Catalog>;
            FillBookMark();
            this.cataLogCbb.Text =catalog;
            this.titleTxtbox.Text=title;
            this.urlTxtbox.Text =url;
        }
        public BookMarkForm(BookMark bookmark, List<Catalog> catalogs)
        {
            InitializeComponent();
            this.catalogs = catalogs;
            Render(bookmark, catalogs);
        }

        private void Render(BookMark bookmark, List<Catalog> catalogs)
        {
            FillBookMark();
            var cataName = catalogs.Where(p => p.CatalogID == bookmark.CatalogID).Select(p => p.CatalogName).FirstOrDefault();
            this.cataLogCbb.Text = cataName;
            this.titleTxtbox.Text = bookmark.Title;
            this.urlTxtbox.Text = bookmark.Url;
        }
        private void FillBookMark()
        {
            foreach (Catalog v in catalogs)
            {
                cataLogCbb.Items.Add(v.CatalogName);
            }
            cataLogCbb.Items.Insert(0,"未分类");
            cataLogCbb.Text = "未分类";
        }

        private void OkBtt_Click(object sender, EventArgs e)
        {
            if (InsertBookMark(this.cataLogCbb.Text, this.titleTxtbox.Text, this.urlTxtbox.Text))
            {
                this.Close();
            }
        }

        private bool InsertBookMark(string catalog, string title, string url)
        {
            var testBooks = bookMarkService.FindBookMarkByTitle(this.titleTxtbox.Text);
            if (testBooks.Count > 0)
            {
                MessageBox.Show("标题重复", "警告", MessageBoxButtons.OK);
                return false;
            }
            BookMark bookmark = new BookMark();
            bookmark.Title = title;
            bookmark.Url = url;
            var myLog = catalogs.Where(p => p.CatalogName == catalog).Select(p => p).FirstOrDefault();
            if (myLog != null)
            {
                bookmark.CatalogID = myLog.CatalogID;
            }
            else
            {
                if (catalog != "未分类")
                {
                    Catalog newLog = bookMarkService.InsertCatalog(new Catalog() { CatalogName = catalog });
                    bookmark.CatalogID = newLog.CatalogID;
                }
            }
            bookMarkService.InsertBookMark(bookmark);
            MessageBox.Show("收藏成功");
            return true;
        }
    }
}

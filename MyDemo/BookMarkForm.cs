using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyDemo.Enity;
using MyDemo.Common;
namespace MyDemo
{
    public partial class BookMarkForm : Form
    {
        private BrowserHelper _browserHelper;
        private List<Catalog> _catalogs; 
        public BookMarkForm()
        {
            InitializeComponent();
            _browserHelper=new BrowserHelper();
            _catalogs = _browserHelper.GetCatalogList();
            this.StartPosition=FormStartPosition.CenterScreen;
        }
        public BookMarkForm(string catalog,string title,string url)
        {
            InitializeComponent();
            _browserHelper = new BrowserHelper();
            _catalogs = _browserHelper.GetCatalogList();
            FillBookMark();
            this.cataLogCbb.Text =catalog;
            this.titleTxtbox.Text=title;
            this.urlTxtbox.Text =url;
        }

        public BookMarkForm(BookMark bm)
        {
           InitializeComponent();
           _browserHelper = new BrowserHelper();
           _catalogs = _browserHelper.GetCatalogList();
           FillBookMark();
           var cataName=_catalogs.Where(p => p.CatalogID == bm.CatalogID).Select(p => p.CatalogName);
            foreach (var v in cataName)
            {
                this.cataLogCbb.Text = v;
            }
            this.titleTxtbox.Text= bm.Title;
            this.urlTxtbox.Text = bm.Url;

        }
        private void FillBookMark()
        {
            foreach (Catalog v in _catalogs)
            {
                cataLogCbb.Items.Add(v.CatalogName);
            }
            cataLogCbb.Items.Insert(0,"未分类");
            cataLogCbb.Text = "未分类";
        }

        private void OkBtt_Click(object sender, EventArgs e)
        {
            InsertBookMark();
            this.Close();
        }

        private void InsertBookMark()
        {
            DataTable testDataTable =
                SqliteHelper.ExecuteDataTable(
                    string.Format("select * from BookMark where title ='{0}'", this.titleTxtbox.Text), null);
            string vv= string.Format("select * from BookMark where title ='{0}'", this.titleTxtbox.Text);
            if (testDataTable.Rows.Count> 0)
            {
                MessageBox.Show("标题重复", "警告", MessageBoxButtons.OK);
                return;
            }
            DataTable dt = SqliteHelper.ExecuteDataTable("select * from BookMark where 0=1", null);
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            dr[1] = this.titleTxtbox.Text;
            dr[2] = this.urlTxtbox.Text;
            var myLog =_catalogs.Where(p => p.CatalogName == this.cataLogCbb.Text).Select(p=>p);
            bool flag = false;
            foreach(var v in myLog)
            {
                if (v.CatalogName == this.cataLogCbb.Text)
                {
                    flag = true;
                    dr[3] = v.CatalogID;
                }
                
            }
            if (!flag)
            {
                if (this.cataLogCbb.Text != "未分类")
                {
                    _browserHelper.InsertCatalog(new Catalog(){CatalogName = this.cataLogCbb.Text});
                    List<Catalog> keyCatas =_browserHelper.GetCatalogList(string.Format("select * from Catalog where CatalogName='{0}'",this.cataLogCbb.Text));
                    dr[3] = keyCatas[0].CatalogID;
                }
            }
            SqliteHelper.UpdateTable("BookMark", "BookMarkID", dt);
            MessageBox.Show("收藏成功");
        }

      
    }
}

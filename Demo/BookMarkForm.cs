using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Demo
{
    public partial class BookMarkForm : Form
    {
        public string Url { set; get; }

        public BookMarkForm(string title,string url,string catalog)
        {
            InitializeComponent();
            this.TitleTxt.Text = title;
            this.UrlTxt.Text = url;
            FillCatalogComBox();
            this.BooksComBox.SelectedIndex = 0;
        }

        public BookMarkForm(BookMark bm)
        {
            InitializeComponent();
            this.TitleTxt.Text = bm.Title;
            this.UrlTxt.Text = bm.Url;
            this.BooksComBox.Text = bm.Catalog;

            FillCatalogComBox();
            this.BooksComBox.SelectedIndex = 0;
        }

        private void FillCatalogComBox()
        {
            try
            {
                this.BooksComBox.Items.Clear();

                string sqlTxt = string.Format("select distinct catalog from bookmarks ");
                string ConnectionString = "Data Source=" + Application.StartupPath + "\\Demo.db";
                SQLiteConnection sqlConnection = new SQLiteConnection(ConnectionString);
                sqlConnection.Open();
                SQLiteCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sqlTxt;
                SQLiteDataReader dr = sqlCommand.ExecuteReader();
                while(dr.Read()){
                    string catalogName = dr[0].ToString();//仅返回的1个字段
                    this.BooksComBox.Items.Add(catalogName);
                }
                this.BooksComBox.Items.Insert(0, "未分类");
                sqlConnection.Close();
            }
            catch (Exception)
            { }
        }

        public BookMarkForm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            string title=this.TitleTxt.Text;
            string url=this.UrlTxt.Text;
            string catalog = this.BooksComBox.Text.Trim();
            SaveBookMark(title, url, catalog);
        }

        private void SaveBookMark(string title, string url, string catalog)
        {
            try
            {
                string sqlTxt = string.Format("insert INTO bookmarks(title,url,catalog) VALUES('{0}','{1}','{2}')", title, url, catalog); 
                string ConnectionString = "Data Source=" + Application.StartupPath + "\\Demo.db";
                SQLiteConnection sqlConnection = new SQLiteConnection(ConnectionString);
                sqlConnection.Open();
                SQLiteCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sqlTxt;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("保存成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.ToLower().Contains("not unique")) {
                    MessageBox.Show("书签名称已存在!","系统提示",MessageBoxButtons.OK);
                }
            }
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

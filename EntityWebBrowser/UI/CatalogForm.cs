using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityWebBrowser.Services;
using EntityWebBrowser.Entity;
namespace EntityWebBrowser.UI
{
    public partial class CatalogForm : Form
    {
        private IBookMarkService bookMarkService = ServicesFactory.BookmarkService;
         private  Catalog catalog;
        public CatalogForm(Catalog catalog)
        {
            InitializeComponent();
            this.catalog = catalog;
        }
        private void CatalogForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = catalog.CatalogName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("不能为空");
                return;
            }
            if (this.textBox1.Text == "未分类")
            {
                MessageBox.Show("不能采用此目录名");
                return;
            }
            this.catalog.CatalogName = this.textBox1.Text;
            bookMarkService.UpdateCatalog(catalog);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}

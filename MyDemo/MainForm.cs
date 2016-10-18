using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNet.Utilities;
using MvvmDemo;
using MyDemo.Common;
using MyDemo.Enity;
using MessageBox = System.Windows.Forms.MessageBox;
namespace MyDemo
{
    public partial class MainForm : MoveableNoBorderForm
    {

        private BrowserHelper _browserHelper = null;
        private Dictionary<string, string> _bookmarkDic = new Dictionary<string, string>();
        private Dictionary<string, string> _recordDic = new Dictionary<string, string>();
        private List<Catalog> _catalogs = null;
        public MainForm()
        {
            InitializeComponent();
            _browserHelper = new BrowserHelper();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel3.Visible = false;
            this.Width = 1000;
            this.Height = 680;
            MoveControl();
        }

        private void MoveControl()
        {
            List<Control> conTrols=new List<Control>();
            conTrols.Add(this.menuStrip1);
            conTrols.Add(this.toolStrip1);
            SetupMoveableForm(conTrols);
        } 

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GoHomeUrl();
        }

        private void GoHomeUrl()
        {
            string urlStr = HomeUrlClass.GetHomeUrl(string.Format("{0}\\HomeUrl.txt", Application.StartupPath));
            webBrowser1.Url = new Uri(urlStr);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GoHomeUrl();
        }

        private void quitBtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBtt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.urlTxtbox.Text))
                return;
            GoToUrl();
        }

        //访问指定网址
        private void GoToUrl()
        {
            string uriStr = "";
            if (urlTxtbox.Text.StartsWith("http://")) uriStr = this.urlTxtbox.Text;
            else
                uriStr = string.Format("http://{0}", this.urlTxtbox.Text);
            this.webBrowser1.Url = new Uri(uriStr);
        }

        private void returnBtt_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoBack();
        }

        private void frontBtt_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoForward();
        }

        private void newWebBtt_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Refresh();
        }

        #region 防止脚本出错且保存访问记录

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //添加下面的处理程序 防止报错
            this.webBrowser1.Document.Window.Error += new HtmlElementErrorEventHandler(Window_Error);
            //如果一个页面中含有多个框架页，那么在每个框架页加载完成时
            //也可能触发一次DocumentCompleted事件,采用此方法避免。
            if (e.Url.ToString() != this.webBrowser1.Url.ToString()) return;
            this.statusLabel.Text = this.webBrowser1.Document.Title;
            this.urlTxtbox.Text = this.webBrowser1.Url.ToString();
            _browserHelper.InsertToRecord(new Record(0, this.webBrowser1.Url.ToString(), this.webBrowser1.Document.Title));
            this.toolStripProgressBar1.Value += 4;
            this.timer1.Enabled = true;
            //如果panel3可见 刷新历史纪录
            if(this.panel3.Visible==true) LoadRecordTree();
        }

        private void Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        private void historyListBtt_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string url = _recordDic[e.ClickedItem.Text];
            this.webBrowser1.Navigate(url);
        }

        private async void historyListBtt_MouseEnter(object sender, EventArgs e)
        {
            historyListBtt.DropDownItems.Clear();
            await Task.Run(() =>
            {
                List<Record> records = _browserHelper.GetRecordList();
                _recordDic = _browserHelper.GetRecordDic(records);
            });
            foreach (var v in _recordDic.Keys)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(v);
                historyListBtt.DropDownItems.Add(menuItem);
            }


        }

        /// <summary>
        /// 防止打开新窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            string urlStr = this.webBrowser1.StatusText; //获取新窗口视图载入网页的url
            e.Cancel = true; //取消创建新窗口
            this.webBrowser1.Navigate(urlStr);
        }

        private void SetMainPageBtt_Click(object sender, EventArgs e)
        {
            //写到TXT文档中
            HomeUrlClass.SetHomeUrl(string.Format("{0}\\HomeUrl.txt", Application.StartupPath),
                this.webBrowser1.Url.ToString());
            //改写配置文件
            Config.UpdateAppConfig("HomeUrl",this.webBrowser1.Url.ToString());
            MessageBox.Show("主页设置成功");
        }

        private void getBookBtt_Click(object sender, EventArgs e)
        {
            new BookMarkForm("", this.webBrowser1.Document.Title, this.webBrowser1.Url.ToString()).ShowDialog();
        }

        private void minBtt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reFormSizebtt_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void BookMarkDropDown_MouseEnter(object sender, EventArgs e)
        {
            BookMarkDropDownBtt.DropDownItems.Clear();
            _catalogs = _browserHelper.GetCatalogList();
            List<BookMark> bookMarks = _browserHelper.GetBookMarkList();
            _bookmarkDic = _browserHelper.GetBookMarkDic(bookMarks);
            foreach (var v in _catalogs)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(v.CatalogName);
                BookMarkDropDownBtt.DropDownItems.Add(toolStripMenuItem);
                toolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(BookMarkDropItem_Click);
                var cataBookMarks = bookMarks.Where(p => p.CatalogID == v.CatalogID);
                foreach (var  cv in cataBookMarks)
                {
                    ToolStripMenuItem tool = new ToolStripMenuItem(cv.Title);
                    ToolStripMenuItem t1 = new ToolStripMenuItem("打开");
                    ToolStripMenuItem t2 = new ToolStripMenuItem("修改");
                    ToolStripMenuItem t3 = new ToolStripMenuItem("删除");
                    tool.DropDownItems.Add(t1);
                    tool.DropDownItems.Add(t2);
                    tool.DropDownItems.Add(t3);
                    tool.DropDownItemClicked += new ToolStripItemClickedEventHandler(BookMarkDropItem_Click);
                    toolStripMenuItem.DropDownItems.Add(tool);
                }
            }
            var noCataBookMarks = bookMarks.Where(p => p.CatalogID == 0);
            foreach (var v in noCataBookMarks)
            {
                ToolStripMenuItem tool = new ToolStripMenuItem(v.Title);
                ToolStripMenuItem t1 = new ToolStripMenuItem("打开");
                ToolStripMenuItem t2 = new ToolStripMenuItem("修改");
                ToolStripMenuItem t3 = new ToolStripMenuItem("删除");
                tool.DropDownItems.Add(t1);
                tool.DropDownItems.Add(t2);
                tool.DropDownItems.Add(t3);
                tool.DropDownItemClicked += new ToolStripItemClickedEventHandler(BookMarkDropItem_Click);
                tool.Click += new EventHandler(BookMark_Click);
                this.BookMarkDropDownBtt.DropDownItems.Add(tool);
            }
        }

        private void BookMarkDropItem_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "打开")
            {
                string url = _bookmarkDic[e.ClickedItem.OwnerItem.Text];
                this.webBrowser1.Url = new Uri(url);
            }
            if (e.ClickedItem.Text == "删除")
            {
                _browserHelper.DeleteBookMark(string.Format("delete  from  bookMark where title ='{0}'",
                    e.ClickedItem.OwnerItem.Text));
                BookMarkDropDown_MouseEnter(null, null);
                MessageBox.Show("删除成功");
                this.webBrowser1.Focus();
            }
            if (e.ClickedItem.Text == "修改")
            {
                string title = e.ClickedItem.OwnerItem.Text;
                string url = _bookmarkDic[title];
                int catalogId = 0;
                if (e.ClickedItem.OwnerItem.OwnerItem != null)
                {
                    string catalogName = e.ClickedItem.OwnerItem.OwnerItem.Text;
                    var cataIds = from v in _catalogs where v.CatalogName == catalogName select v.CatalogID;
                    foreach (var v in cataIds)
                    {
                        catalogId = v;
                    }
                }
                BookMark bm = new BookMark();
                bm.Title = title;
                bm.CatalogID = catalogId;
                bm.Url = url;
                new BookMarkForm(bm).Show();
            }
        }

        private void BookMark_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tool = sender as ToolStripMenuItem;
            string url = _bookmarkDic[tool.Text];
            this.webBrowser1.Url = new Uri(url);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.panel3.Visible = !this.panel3.Visible;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.toolStripProgressBar1.Visible = true;
            this.toolStripProgressBar1.Minimum = 0;
            this.toolStripProgressBar1.Maximum = 4;
            this.toolStripProgressBar1.Value = 0;
        }

        private void urlTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.goBtt.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Visible = false;
            this.timer1.Enabled = false;
        }

        private void panel3_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                LoadBookMarkTree();
                LoadRecordTree();
            }
        }

        private void LoadBookMarkTree()
        {
            this.bookMarkTree.Nodes.Clear();
            List<Catalog> catalogs = _browserHelper.GetCatalogList();
            List<BookMark> bookMarks = _browserHelper.GetBookMarkList();
            _bookmarkDic = _browserHelper.GetBookMarkDic(bookMarks);
            foreach (var v in catalogs)
            {
                TreeNode cataNode = new TreeNode(v.CatalogName);
                cataNode.NodeFont = new Font("楷书", 10);
                var cataBookMarks = bookMarks.Where(p => p.CatalogID == v.CatalogID);
                foreach (var mark in cataBookMarks)
                {
                    TreeNode markNode = new TreeNode(mark.Title);
                    markNode.NodeFont = new Font("楷书", 8);
                    cataNode.Nodes.Add(markNode);
                }
                this.bookMarkTree.Nodes.Add(cataNode);
            }
            TreeNode noCataNode = new TreeNode("未分类");
            noCataNode.NodeFont = new Font("楷书", 10);
            var noCaBooks = bookMarks.Where(p => p.CatalogID == 0);
            foreach (var mark in noCaBooks)
            {
                TreeNode markNode = new TreeNode(mark.Title);
                markNode.NodeFont = new Font("楷书", 8);
                noCataNode.Nodes.Add(markNode);
            }
            this.bookMarkTree.Nodes.Add(noCataNode);
        }

        private void LoadRecordTree()
        {
            this.recordTree.Nodes.Clear();
            List<Record> records=_browserHelper.GetRecordList();
            _recordDic = _browserHelper.GetRecordDic(records);
            foreach (var v in records)
            {
                TreeNode tNode=new TreeNode(v.Title);
                recordTree.Nodes.Add(tNode);
            }
        }

        private void recordTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string url = _recordDic[e.Node.Text];
            this.webBrowser1.Url=new Uri(url);
        }

        private void bookMarkTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                string url = _bookmarkDic[e.Node.Text];
                this.webBrowser1.Url=new Uri(url);
            }
        }

        private void ClearRecorBtt_Click(object sender, EventArgs e)
        {
            _browserHelper.DeleteRecord("delete from record");
            LoadRecordTree();
        }

        private void DeleteRecordBtt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(titleRecord))
            {
                _browserHelper.DeleteRecord(string.Format("delete from record where title ='{0}'", titleRecord));
                LoadRecordTree();
            }
        }

        private string titleRecord="";
        private void recordTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            titleRecord = e.Node.Text;
        }

        private string bookTitle = "";
        private string catalogName = "";
        private void bookMarkTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                bookTitle = e.Node.Text;
            }
            else
            {
                catalogName = e.Node.Text;
            }
        }

        private void DeletebmBtt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bookTitle))
            {
                _browserHelper.DeleteBookMark(string.Format("delete  from  BookMark where title ='{0}'",bookTitle));
                LoadBookMarkTree();
            }
        }

        private void 保存网页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HtmlClass.SaveHtml(this.webBrowser1.Url.ToString(),
                string.Format("{0}\\Html\\{1}.html", Application.StartupPath, this.webBrowser1.DocumentTitle)))
                MessageBox.Show("保存成功");
        }

       
    }



}


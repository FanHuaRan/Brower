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
using MessageBox = System.Windows.Forms.MessageBox;
using EntityWebBrowser.Entity;
using EntityWebBrowser.Services;
using EntityWebBrowser.UI;
namespace EntityWebBrowser
{
    public partial class MainForm : MoveableNoBorderForm
    {
        private IBookMarkService bookMarkService = null;
        private IRecordService recordService = null;
        private IHomeUrlService homeUrlService = null;
        private List<Catalog> _Catalogs = null;
        private List<Record> _Records = null;
        private List<BookMark> _Bookmarks = null;
        public MainForm()
        {
            InitializeComponent();
            bookMarkService = ServicesFactory.BookmarkService;
            recordService = ServicesFactory.RecordService;
            homeUrlService = ServicesFactory.HomeUrlService;
            InitialUI();
            InitialVarible();
        }

        private void InitialUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel3.Visible = false;
            this.Width = 1000;
            this.Height = 680;
            MoveControl();
        }
        private void InitialVarible()
        {
            this._Records=recordService.FindRecords() as List<Record>;
            this._Catalogs = bookMarkService.FindCatalogs() as List<Catalog>;
            this._Bookmarks = bookMarkService.FindBookMarks() as List<BookMark>;
        }

        private void MoveControl()
        {
            List<Control> conTrols = new List<Control>();
            conTrols.Add(this.menuStrip1);
            conTrols.Add(this.toolStrip1);
            SetupMoveableForm(conTrols);
        }
        private string GetBookmarkUrl(string title)
        {
            BookMark bookmark = this._Bookmarks.Where(p => p.Title == title).FirstOrDefault();
            if (bookmark != null)
            {
                return bookmark.Title;
            }
            else
            {
                return null;
            }
        }
        private string GetRecordUrl(string title)
        {
            Record record = this._Records.Where(p => p.Title == title).FirstOrDefault();
            if (record != null)
            {
                return record.Title;
            }
            else
            {
                return null;
            }
        }
        private void GoToBookmarkByTitle(string title)
        {
            string url = GetBookmarkUrl(title);
            if (url != null)
            {
                this.webBrowser1.Url = new Uri(url);
            }
        }
        private void GoToRecordByTitle(string title)
        {
            string url = GetRecordUrl(title);
            if (url != null)
            {
                this.webBrowser1.Url = new Uri(url);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GoHomeUrl();
        }

        private void GoHomeUrl()
        {
            string urlStr = homeUrlService.GetHomeUrl();
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
            string uriStr = this.urlTxtbox.Text; ;
            if (!uriStr.StartsWith("http://"))
            {
                uriStr = string.Format("http://{0}", this.urlTxtbox.Text);
            }
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
            InsertRecord();
            this.toolStripProgressBar1.Value += 4;
            this.timer1.Enabled = true;
            //如果panel3可见 刷新历史纪录
            if (this.panel3.Visible == true) LoadRecordTree();
        }

        private void InsertRecord()
        {
            Record newRecord = recordService.InsertRecord(new Record(-1, this.webBrowser1.Url.ToString(), this.webBrowser1.Document.Title));
            if (newRecord != null)
            {
                this._Records.Add(newRecord);
            }
        }

        private void Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        private void historyListBtt_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Record record = this._Records.Where(p => p.Title == e.ClickedItem.Text).FirstOrDefault();
            this.webBrowser1.Navigate(record.Url);
        }

        private async void historyListBtt_MouseEnter(object sender, EventArgs e)
        {
            historyListBtt.DropDownItems.Clear();
            List<Record> records = null;
            await Task.Run(() =>
            {
                records = recordService.FindRecords() as List<Record>;
            });
            foreach (var v in records)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(v.Title);
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
            if (!string.IsNullOrEmpty(this.webBrowser1.Url.ToString()))
            {
                homeUrlService.UpdateHomeUrl(this.webBrowser1.Url.ToString());
            }
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
            this._Catalogs = bookMarkService.FindCatalogs() as List<Catalog>;
            this._Bookmarks = bookMarkService.FindBookMarks() as List<BookMark>;
            foreach (var v in _Catalogs)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(v.CatalogName);
                toolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(BookMarkDropItem_Click);
                var cataBookMarks = _Bookmarks.Where(p => p.CatalogID == v.CatalogID);
                foreach (var cv in cataBookMarks)
                {
                    ToolStripMenuItem tool = CreatTool(cv);
                    toolStripMenuItem.DropDownItems.Add(tool);
                }
                BookMarkDropDownBtt.DropDownItems.Add(toolStripMenuItem);
            }
            var noCataBookMarks = _Bookmarks.Where(p => p.CatalogID == null);
            foreach (var v in noCataBookMarks)
            {
                ToolStripMenuItem tool = CreatTool(v);
                tool.Click += new EventHandler(BookMark_Click);
                this.BookMarkDropDownBtt.DropDownItems.Add(tool);
            }
        }

        private ToolStripMenuItem CreatTool(BookMark cv)
        {
            ToolStripMenuItem tool = new ToolStripMenuItem(cv.Title);
            ToolStripMenuItem t1 = new ToolStripMenuItem("打开");
            ToolStripMenuItem t2 = new ToolStripMenuItem("修改");
            ToolStripMenuItem t3 = new ToolStripMenuItem("删除");
            tool.DropDownItems.Add(t1);
            tool.DropDownItems.Add(t2);
            tool.DropDownItems.Add(t3);
            tool.DropDownItemClicked += new ToolStripItemClickedEventHandler(BookMarkDropItem_Click);
            return tool;
        }

        private void BookMarkDropItem_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            string title = e.ClickedItem.OwnerItem.Text;
            if (e.ClickedItem.Text == "打开")
            {
                GoToBookmarkByTitle(title);
            }
            if (e.ClickedItem.Text == "删除")
            {
                bookMarkService.DeleteBookMarkByTitle(title);
                BookMarkDropDown_MouseEnter(null, null);
                MessageBox.Show("删除成功");
                this.webBrowser1.Focus();
            }
            if (e.ClickedItem.Text == "修改")
            {
                BookMark bookmark = this._Bookmarks.Where(p => p.Title == title).FirstOrDefault();
                new BookMarkForm(bookmark,_Catalogs).Show();
            }
        }
        private void BookMark_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tool = sender as ToolStripMenuItem;
            string url = GetBookmarkUrl(tool.Text);
            if (url != null)
            {
                this.webBrowser1.Url = new Uri(url);
            }
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
            this._Bookmarks= bookMarkService.FindBookMarks() as List<BookMark>;
            this._Catalogs = bookMarkService.FindCatalogs() as List<Catalog>;
            foreach (var v in _Catalogs)
            {
                TreeNode cataNode = new TreeNode(v.CatalogName);
                cataNode.NodeFont = new Font("楷书", 10);
                var cataBookMarks = _Bookmarks.Where(p => p.CatalogID == v.CatalogID);
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
            var noCaBooks = _Bookmarks.Where(p => p.CatalogID == null);
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
            this._Records= recordService.FindRecords() as List<Record>;
            foreach (var v in _Records)
            {
                TreeNode tNode = new TreeNode(v.Title);
                recordTree.Nodes.Add(tNode);
            }
        }

        private void recordTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            GoToRecordByTitle(e.Node.Text);
        }

        private void bookMarkTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                GoToBookmarkByTitle(e.Node.Text);
            }
        }

        private string titleRecord = "";
        private string bookTitle = "";
        private string catalogName = "";
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.panel3.Visible = !this.panel3.Visible;
            this.titleRecord = "";
            this.bookTitle = "";
            this.catalogName = "";

        }
        private void ClearRecorBtt_Click(object sender, EventArgs e)
        {
            recordService.ClearRecords();
            LoadRecordTree();
        }

        private void DeleteRecordBtt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(titleRecord))
            {
                recordService.DeleteRecordByTitle(titleRecord);
                LoadRecordTree();
            }
        }

        private void recordTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            titleRecord = e.Node.Text;
        }

        
        private void bookMarkTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                bookTitle = e.Node.Text;
                catalogName = "";
            }
            else
            {
                catalogName = e.Node.Text;
                bookTitle = "";
            }
        }

        private void DeletebmBtt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bookTitle))
            {
                bookMarkService.DeleteBookMarkByTitle(bookTitle);
            }
            if (!string.IsNullOrEmpty(catalogName)&&catalogName!="未分类")
            {
                bookMarkService.DeleteCatalogByName(catalogName);
            }
            LoadBookMarkTree();
        }
        
        private void UpdateBmBtt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bookTitle))
            {
                BookMark bookmark = this._Bookmarks.Where(p => p.Title==bookTitle).FirstOrDefault();
                new BookMarkForm(bookmark, _Catalogs).ShowDialog();
            }
            if (!string.IsNullOrEmpty(catalogName) && catalogName != "未分类")
            {
                Catalog catalog = this._Catalogs.Where(p => p.CatalogName == catalogName).FirstOrDefault();
                new CatalogForm(catalog).ShowDialog();
            }
            LoadBookMarkTree();
           
        }
        private void 保存网页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (HtmlClass.SaveHtml(this.webBrowser1.Url.ToString(),
            //    string.Format("{0}\\Html\\{1}.html", Application.StartupPath, this.webBrowser1.DocumentTitle)))
            //    MessageBox.Show("保存成功");
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}


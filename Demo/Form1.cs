using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Configuration;
using DotNet.Utilities;

namespace Demo
{
    /// <summary>
    /// 为方便同学们的理解，我基于Form基类派生了一个MoveableNoBorderForm（实现了无边框移动调整），
    /// Form1自MoveableNoBorderForm派生，隐藏了一些对你们来说相对复杂的实现代码。
    /// </summary>
    public partial class Form1 : MoveableNoBorderForm
    {     

        public Form1()
        {
            InitializeComponent();

            //this.FormBorderStyle 为 None 时，若不如此处理，FormWindowState.Maximized 会遮盖任务栏
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            SetupMoveableForm();//将当前窗体上的控件与基类中的方法关联，实现基于指定控件的移动调整操作。
        }

        private void SetupMoveableForm()
        {
            List<Control> relatedControl = new List<Control>();
            relatedControl.Add(this.menuStrip1);
            relatedControl.Add(this.toolStrip1);
            SetupMoveableForm(relatedControl);//基类中的方法
        }
      
        private void 打开网址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrlForm urlF = new UrlForm();
            urlF.ShowDialog();
            if(urlF.DialogResult==DialogResult.OK){
                this.webBrowser.Url = new Uri(urlF.Url); 
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("确定退出?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel) return;
            Application.Exit();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void GoHome() {
            string url =ConfigurationManager.AppSettings["HomeUrl"].ToString();
            this.webBrowser.Navigate(url);
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //如果一个页面中含有多个框架页，那么在每个框架页加载完成时也可能触发一次DocumentCompleted事件,采用此方法避免。
            if (e.Url.ToString() != webBrowser.Url.ToString()) return;
            try
            {
                WriteToTxt(DateTime.Now.ToString(),this.webBrowser.Document.Title, this.webBrowser.Url.AbsoluteUri);
                WriteToDataBase(this.webBrowser.Url.AbsoluteUri);
                this.toolStripTextBox1.Text = this.webBrowser.Url.AbsoluteUri;
                this.StatusTitle.Text = this.webBrowser.Document.Title;
                this.Text = this.webBrowser.Document.Title;
            }
            catch (Exception ex)
            { }
        }

        private void WriteToDataBase(string p)
        {
          //也可以把浏览记录写到Sqlite中
        }

        private void WriteToTxt(string time,string title,string url)
        {
            string filePath = Application.StartupPath + "\\history.txt";

            //FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(time +"|" + title + "|" + url);
            sw.Close();

            //fs.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string url=this.toolStripTextBox1.Text.Trim();
            if (string.IsNullOrEmpty(url)) return;
            if (!url.Contains("http://")) url = "http://" + url;
            this.webBrowser.Url = new Uri(url);
        }


        private void BookFalg_MouseEnter(object sender, EventArgs e)
        {
            BookMarksBtn.DropDownItems.Clear();
            UrlDic.Clear();

            List<BookMark> BookMarkList = LoadBookMarks();
            IEnumerable<IGrouping<string, BookMark>> catalogLst = BookMarkList.GroupBy(x => x.Catalog);
            foreach (var catalog in catalogLst)
            {
                ToolStripMenuItem Tit = new ToolStripMenuItem(catalog.Key);
                Tit.DropDownItemClicked += new ToolStripItemClickedEventHandler(Tit_DropDownItemClicked);
                foreach (var item in catalog)
                {
                    ToolStripMenuItem i = new ToolStripMenuItem(item.Title);
                    Tit.DropDownItems.Add(i);
                    UrlDic.Add(item.Title, item.Url);
                }
                BookMarksBtn.DropDownItems.Add(Tit);
            }
        }

        void Tit_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            BookMarksBtn_DropDownItemClicked(null, e);
        }
        private List<History> LoadHistory()
        {
            List<History> Result = new List<History>();
            try
            {
                string filePath = Application.StartupPath + "\\history.txt";
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string r = sr.ReadLine();
                while (!string.IsNullOrEmpty(r))
                {
                    try
                    {
                        string[] ds = r.Split('|');
                        string time = ds[0];
                        string Title = ds[1];
                        string Url = ds[2];
                        Result.Add(new History(time, Title, Url));
                    }
                    catch (Exception)
                    { }
                    finally {
                        r = sr.ReadLine();
                    }
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception)
            { }
            return Result;
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) toolStripButton4_Click(null, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.webBrowser.GoBack();
        }

        private void HistoryBtn_MouseEnter(object sender, EventArgs e)
        {
            HistoryBtn.DropDownItems.Clear();
            HistoryDic = LoadHistory();
            foreach (var item in HistoryDic)
            {
                ToolStripMenuItem i = new ToolStripMenuItem(item.Title);
                HistoryBtn.DropDownItems.Add(i);
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            string NewURL = this.webBrowser.StatusText;  //获得 要求以新窗口载入内容的链接的字符串
            e.Cancel = true; //停止新建窗口
            this.webBrowser.Url=new Uri(NewURL);// 加载新的页面
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
                 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.webBrowser.GoForward();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.webBrowser.Refresh();
        }

        private void HistoryClearMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\history.txt";
            File.Delete(filePath);
        }

        private Dictionary<string, string> UrlDic = new Dictionary<string, string>();
        private List<History> HistoryDic = null;    

        private List<BookMark> LoadBookMarks()
        {
            List<BookMark> Lst = new List<BookMark>();
            string sqlTxt = " SELECT title,url,catalog from BookMarks ; ";
            string ConnectionString = "Data Source="+ Application.StartupPath +"\\Demo.db";
            SQLiteConnection sqlConnection = new SQLiteConnection(ConnectionString);
            sqlConnection.Open();
            SQLiteCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sqlTxt;
            SQLiteDataAdapter Datapter = new SQLiteDataAdapter(sqlCommand);
            DataTable dt = new DataTable("BookMarks"); 
            Datapter.Fill(dt);
            sqlConnection.Close();
            DataRowCollection Rows = dt.Rows;
            foreach (DataRow item in Rows)
            {
                BookMark bk = new BookMark();
                bk.Title = item[0].ToString();
                bk.Url = item[1].ToString();
                bk.Catalog = item[2].ToString();
                Lst.Add(bk);
            }
            return Lst;
        }

        private void BookMarkslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookMarksCMenu_MouseLeave(object sender, EventArgs e)
        {
            BookMarksCMenu.Hide();
        }

        private void BookMarksBtn_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                string Url = UrlDic[e.ClickedItem.Text];
                this.webBrowser.Navigate(Url);
            }
            catch (Exception)
            { }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            processBar.Visible = true;
            if ((e.CurrentProgress > 0) && (e.MaximumProgress > 0))
            {
                processBar.Maximum = Convert.ToInt32(e.MaximumProgress);
                processBar.Step = Convert.ToInt32(e.CurrentProgress);
                processBar.PerformStep();
            }
            else if (this.webBrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                processBar.Value = 0;
                processBar.Visible = false;
            }
        }

        private void ManageBookMarks_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string title = this.webBrowser.Document.Title;
                string url = this.webBrowser.Url.ToString();
                string catalog = "未分类";

                BookMark bm = new BookMark();
                bm.Title = title;
                bm.Url = url;
                bm.Catalog = catalog;

                BookMarkForm bkf = new BookMarkForm(bm);
                bkf.ShowDialog();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("人品不好，换个时间再来!","系统提示");
            }
        }

        private void HistoryBtn_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                string url = HistoryDic.Find(p => p.Title == e.ClickedItem.Text).Url;
                if (!url.Contains("http://")) url = "http://" + url;
                this.webBrowser.Url = new Uri(url); 
            }
            catch (Exception)
            { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = System.Configuration.ConfigurationManager.AppSettings["FormTitle"].ToString();
            string url = "http://www.baidu.com";
            //this.webBrowser.Url = new Uri(url);
            this.webBrowser.Navigate(@"http://www.baidu.com");
        }

        private void 设置主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration("Demo.exe");
            string HomeUrl = configuration.AppSettings.Settings["HomeUrl"].Value;
            string NewUrl=this.webBrowser.Url.ToString();
            if (HomeUrl!=NewUrl)
            {
                configuration.AppSettings.Settings.Remove("HomeUrl");
                configuration.AppSettings.Settings.Add("HomeUrl", NewUrl);
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            System.Windows.Forms.MessageBox.Show("设置成功!","系统提示");
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.panel1.Visible = !this.panel1.Visible;
        }
        private void PnlHeader_DoubleClick()
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {  
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
        }

        private void menuStrip1_DoubleClick(object sender, EventArgs e)
        {
            PnlHeader_DoubleClick();
        }

        private void toolStrip1_DoubleClick(object sender, EventArgs e)
        {
            PnlHeader_DoubleClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PnlHeader_DoubleClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlHeader_DoubleClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(System.Windows.Forms.MessageBox.Show("确定退出浏览？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) this.Close();
        }

        private void 收藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BookMarksBtn_Click(object sender, EventArgs e)
        {

        }

    }
}

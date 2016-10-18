namespace MyDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minBtt = new System.Windows.Forms.Button();
            this.quitBtt = new System.Windows.Forms.Button();
            this.reFormSizebtt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存网页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开网页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收藏网址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清楚浏览记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.截图小工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开发工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mainStrpButton = new System.Windows.Forms.ToolStripButton();
            this.getBookBtt = new System.Windows.Forms.ToolStripButton();
            this.returnBtt = new System.Windows.Forms.ToolStripButton();
            this.frontBtt = new System.Windows.Forms.ToolStripButton();
            this.newWebBtt = new System.Windows.Forms.ToolStripButton();
            this.BookMarkDropDownBtt = new System.Windows.Forms.ToolStripDropDownButton();
            this.urlTxtbox = new System.Windows.Forms.ToolStripTextBox();
            this.goBtt = new System.Windows.Forms.ToolStripButton();
            this.historyListBtt = new System.Windows.Forms.ToolStripDropDownButton();
            this.HelpBtt = new System.Windows.Forms.ToolStripButton();
            this.SetMainPageBtt = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteRecordBtt = new System.Windows.Forms.Button();
            this.ClearRecorBtt = new System.Windows.Forms.Button();
            this.recordTree = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeletebmBtt = new System.Windows.Forms.Button();
            this.UpdateBmBtt = new System.Windows.Forms.Button();
            this.bookMarkTree = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minBtt);
            this.panel1.Controls.Add(this.quitBtt);
            this.panel1.Controls.Add(this.reFormSizebtt);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 32);
            this.panel1.TabIndex = 0;
            // 
            // minBtt
            // 
            this.minBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtt.Location = new System.Drawing.Point(900, 0);
            this.minBtt.Name = "minBtt";
            this.minBtt.Size = new System.Drawing.Size(28, 23);
            this.minBtt.TabIndex = 2;
            this.minBtt.Text = "button2";
            this.toolTip1.SetToolTip(this.minBtt, "最小化");
            this.minBtt.UseVisualStyleBackColor = true;
            this.minBtt.Click += new System.EventHandler(this.minBtt_Click);
            // 
            // quitBtt
            // 
            this.quitBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtt.Location = new System.Drawing.Point(970, 0);
            this.quitBtt.Name = "quitBtt";
            this.quitBtt.Size = new System.Drawing.Size(28, 23);
            this.quitBtt.TabIndex = 3;
            this.quitBtt.Text = "button3";
            this.toolTip1.SetToolTip(this.quitBtt, "退出");
            this.quitBtt.UseVisualStyleBackColor = true;
            this.quitBtt.Click += new System.EventHandler(this.quitBtt_Click);
            // 
            // reFormSizebtt
            // 
            this.reFormSizebtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reFormSizebtt.Location = new System.Drawing.Point(934, 0);
            this.reFormSizebtt.Name = "reFormSizebtt";
            this.reFormSizebtt.Size = new System.Drawing.Size(30, 23);
            this.reFormSizebtt.TabIndex = 1;
            this.reFormSizebtt.Text = "button1";
            this.reFormSizebtt.UseVisualStyleBackColor = true;
            this.reFormSizebtt.Click += new System.EventHandler(this.reFormSizebtt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.收藏ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存网页ToolStripMenuItem,
            this.打开网页ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存网页ToolStripMenuItem
            // 
            this.保存网页ToolStripMenuItem.Name = "保存网页ToolStripMenuItem";
            this.保存网页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存网页ToolStripMenuItem.Text = "保存网页";
            this.保存网页ToolStripMenuItem.Click += new System.EventHandler(this.保存网页ToolStripMenuItem_Click);
            // 
            // 打开网页ToolStripMenuItem
            // 
            this.打开网页ToolStripMenuItem.Name = "打开网页ToolStripMenuItem";
            this.打开网页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开网页ToolStripMenuItem.Text = "打开网页";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 收藏ToolStripMenuItem
            // 
            this.收藏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收藏网址ToolStripMenuItem});
            this.收藏ToolStripMenuItem.Name = "收藏ToolStripMenuItem";
            this.收藏ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.收藏ToolStripMenuItem.Text = "收藏";
            // 
            // 收藏网址ToolStripMenuItem
            // 
            this.收藏网址ToolStripMenuItem.Name = "收藏网址ToolStripMenuItem";
            this.收藏网址ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.收藏网址ToolStripMenuItem.Text = "收藏网址";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清楚浏览记录ToolStripMenuItem,
            this.截图小工具ToolStripMenuItem,
            this.下载管理ToolStripMenuItem,
            this.开发工具ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 清楚浏览记录ToolStripMenuItem
            // 
            this.清楚浏览记录ToolStripMenuItem.Name = "清楚浏览记录ToolStripMenuItem";
            this.清楚浏览记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清楚浏览记录ToolStripMenuItem.Text = "清楚浏览记录";
            // 
            // 截图小工具ToolStripMenuItem
            // 
            this.截图小工具ToolStripMenuItem.Name = "截图小工具ToolStripMenuItem";
            this.截图小工具ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.截图小工具ToolStripMenuItem.Text = "截图小工具";
            // 
            // 下载管理ToolStripMenuItem
            // 
            this.下载管理ToolStripMenuItem.Name = "下载管理ToolStripMenuItem";
            this.下载管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.下载管理ToolStripMenuItem.Text = "下载管理";
            // 
            // 开发工具ToolStripMenuItem
            // 
            this.开发工具ToolStripMenuItem.Name = "开发工具ToolStripMenuItem";
            this.开发工具ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.开发工具ToolStripMenuItem.Text = "开发工具";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 29);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.mainStrpButton,
            this.getBookBtt,
            this.returnBtt,
            this.frontBtt,
            this.newWebBtt,
            this.BookMarkDropDownBtt,
            this.urlTxtbox,
            this.goBtt,
            this.historyListBtt,
            this.HelpBtt,
            this.SetMainPageBtt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(998, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "面板";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // mainStrpButton
            // 
            this.mainStrpButton.Image = ((System.Drawing.Image)(resources.GetObject("mainStrpButton.Image")));
            this.mainStrpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainStrpButton.Name = "mainStrpButton";
            this.mainStrpButton.Size = new System.Drawing.Size(52, 22);
            this.mainStrpButton.Text = "主页";
            this.mainStrpButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // getBookBtt
            // 
            this.getBookBtt.Image = ((System.Drawing.Image)(resources.GetObject("getBookBtt.Image")));
            this.getBookBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.getBookBtt.Name = "getBookBtt";
            this.getBookBtt.Size = new System.Drawing.Size(52, 22);
            this.getBookBtt.Text = "收藏";
            this.getBookBtt.Click += new System.EventHandler(this.getBookBtt_Click);
            // 
            // returnBtt
            // 
            this.returnBtt.Image = ((System.Drawing.Image)(resources.GetObject("returnBtt.Image")));
            this.returnBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.returnBtt.Name = "returnBtt";
            this.returnBtt.Size = new System.Drawing.Size(52, 22);
            this.returnBtt.Text = "后退";
            this.returnBtt.Click += new System.EventHandler(this.returnBtt_Click);
            // 
            // frontBtt
            // 
            this.frontBtt.Image = ((System.Drawing.Image)(resources.GetObject("frontBtt.Image")));
            this.frontBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.frontBtt.Name = "frontBtt";
            this.frontBtt.Size = new System.Drawing.Size(52, 22);
            this.frontBtt.Text = "前进";
            this.frontBtt.Click += new System.EventHandler(this.frontBtt_Click);
            // 
            // newWebBtt
            // 
            this.newWebBtt.Image = ((System.Drawing.Image)(resources.GetObject("newWebBtt.Image")));
            this.newWebBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newWebBtt.Name = "newWebBtt";
            this.newWebBtt.Size = new System.Drawing.Size(52, 22);
            this.newWebBtt.Text = "刷新";
            this.newWebBtt.Click += new System.EventHandler(this.newWebBtt_Click);
            // 
            // BookMarkDropDownBtt
            // 
            this.BookMarkDropDownBtt.Image = ((System.Drawing.Image)(resources.GetObject("BookMarkDropDownBtt.Image")));
            this.BookMarkDropDownBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookMarkDropDownBtt.Name = "BookMarkDropDownBtt";
            this.BookMarkDropDownBtt.Size = new System.Drawing.Size(61, 22);
            this.BookMarkDropDownBtt.Text = "书签";
            this.BookMarkDropDownBtt.MouseEnter += new System.EventHandler(this.BookMarkDropDown_MouseEnter);
            // 
            // urlTxtbox
            // 
            this.urlTxtbox.Name = "urlTxtbox";
            this.urlTxtbox.Size = new System.Drawing.Size(200, 25);
            this.urlTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlTxtbox_KeyPress);
            // 
            // goBtt
            // 
            this.goBtt.Image = ((System.Drawing.Image)(resources.GetObject("goBtt.Image")));
            this.goBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBtt.Name = "goBtt";
            this.goBtt.Size = new System.Drawing.Size(52, 22);
            this.goBtt.Text = "前往";
            this.goBtt.Click += new System.EventHandler(this.goBtt_Click);
            // 
            // historyListBtt
            // 
            this.historyListBtt.Image = ((System.Drawing.Image)(resources.GetObject("historyListBtt.Image")));
            this.historyListBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyListBtt.Name = "historyListBtt";
            this.historyListBtt.Size = new System.Drawing.Size(61, 22);
            this.historyListBtt.Text = "历史";
            this.historyListBtt.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.historyListBtt_DropDownItemClicked);
            this.historyListBtt.MouseEnter += new System.EventHandler(this.historyListBtt_MouseEnter);
            // 
            // HelpBtt
            // 
            this.HelpBtt.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtt.Image")));
            this.HelpBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpBtt.Name = "HelpBtt";
            this.HelpBtt.Size = new System.Drawing.Size(52, 22);
            this.HelpBtt.Text = "帮助";
            // 
            // SetMainPageBtt
            // 
            this.SetMainPageBtt.Image = ((System.Drawing.Image)(resources.GetObject("SetMainPageBtt.Image")));
            this.SetMainPageBtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetMainPageBtt.Name = "SetMainPageBtt";
            this.SetMainPageBtt.Size = new System.Drawing.Size(76, 22);
            this.SetMainPageBtt.Text = "设为主页";
            this.SetMainPageBtt.Click += new System.EventHandler(this.SetMainPageBtt_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(998, 515);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(1, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(998, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 516);
            this.panel3.TabIndex = 8;
            this.panel3.VisibleChanged += new System.EventHandler(this.panel3_VisibleChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteRecordBtt);
            this.tabPage1.Controls.Add(this.ClearRecorBtt);
            this.tabPage1.Controls.Add(this.recordTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "浏览记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteRecordBtt
            // 
            this.DeleteRecordBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRecordBtt.Location = new System.Drawing.Point(120, 431);
            this.DeleteRecordBtt.Name = "DeleteRecordBtt";
            this.DeleteRecordBtt.Size = new System.Drawing.Size(75, 23);
            this.DeleteRecordBtt.TabIndex = 2;
            this.DeleteRecordBtt.Text = "删除记录";
            this.DeleteRecordBtt.UseVisualStyleBackColor = true;
            this.DeleteRecordBtt.Click += new System.EventHandler(this.DeleteRecordBtt_Click);
            // 
            // ClearRecorBtt
            // 
            this.ClearRecorBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearRecorBtt.Location = new System.Drawing.Point(23, 431);
            this.ClearRecorBtt.Name = "ClearRecorBtt";
            this.ClearRecorBtt.Size = new System.Drawing.Size(75, 23);
            this.ClearRecorBtt.TabIndex = 1;
            this.ClearRecorBtt.Text = "清空记录";
            this.ClearRecorBtt.UseVisualStyleBackColor = true;
            this.ClearRecorBtt.Click += new System.EventHandler(this.ClearRecorBtt_Click);
            // 
            // recordTree
            // 
            this.recordTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordTree.Location = new System.Drawing.Point(3, 3);
            this.recordTree.Name = "recordTree";
            this.recordTree.Size = new System.Drawing.Size(236, 484);
            this.recordTree.TabIndex = 0;
            this.recordTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.recordTree_AfterSelect);
            this.recordTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.recordTree_NodeMouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeletebmBtt);
            this.tabPage2.Controls.Add(this.UpdateBmBtt);
            this.tabPage2.Controls.Add(this.bookMarkTree);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "书签收藏";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeletebmBtt
            // 
            this.DeletebmBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeletebmBtt.Location = new System.Drawing.Point(122, 447);
            this.DeletebmBtt.Name = "DeletebmBtt";
            this.DeletebmBtt.Size = new System.Drawing.Size(75, 23);
            this.DeletebmBtt.TabIndex = 3;
            this.DeletebmBtt.Text = "删除";
            this.DeletebmBtt.UseVisualStyleBackColor = true;
            this.DeletebmBtt.Click += new System.EventHandler(this.DeletebmBtt_Click);
            // 
            // UpdateBmBtt
            // 
            this.UpdateBmBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateBmBtt.Location = new System.Drawing.Point(18, 447);
            this.UpdateBmBtt.Name = "UpdateBmBtt";
            this.UpdateBmBtt.Size = new System.Drawing.Size(75, 23);
            this.UpdateBmBtt.TabIndex = 2;
            this.UpdateBmBtt.Text = "修改";
            this.UpdateBmBtt.UseVisualStyleBackColor = true;
            // 
            // bookMarkTree
            // 
            this.bookMarkTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookMarkTree.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookMarkTree.Location = new System.Drawing.Point(3, 3);
            this.bookMarkTree.Name = "bookMarkTree";
            this.bookMarkTree.Size = new System.Drawing.Size(236, 484);
            this.bookMarkTree.TabIndex = 1;
            this.bookMarkTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.bookMarkTree_AfterSelect);
            this.bookMarkTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.bookMarkTree_NodeMouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.webBrowser1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(998, 515);
            this.panel4.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minBtt;
        private System.Windows.Forms.Button quitBtt;
        private System.Windows.Forms.Button reFormSizebtt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton mainStrpButton;
        private System.Windows.Forms.ToolStripButton getBookBtt;
        private System.Windows.Forms.ToolStripButton returnBtt;
        private System.Windows.Forms.ToolStripButton frontBtt;
        private System.Windows.Forms.ToolStripButton newWebBtt;
        private System.Windows.Forms.ToolStripDropDownButton BookMarkDropDownBtt;
        private System.Windows.Forms.ToolStripTextBox urlTxtbox;
        private System.Windows.Forms.ToolStripButton goBtt;
        private System.Windows.Forms.ToolStripDropDownButton historyListBtt;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton HelpBtt;
        private System.Windows.Forms.ToolStripButton SetMainPageBtt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView recordTree;
        private System.Windows.Forms.TreeView bookMarkTree;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem 保存网页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开网页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收藏网址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清楚浏览记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 截图小工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开发工具ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DeletebmBtt;
        private System.Windows.Forms.Button UpdateBmBtt;
        private System.Windows.Forms.Button DeleteRecordBtt;
        private System.Windows.Forms.Button ClearRecorBtt;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
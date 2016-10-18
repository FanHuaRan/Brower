namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUrl_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHtmlFile_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveHtmlFile_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppExit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryClear_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageBookMarks_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.HomeBtn = new System.Windows.Forms.ToolStripButton();
            this.BackBtn = new System.Windows.Forms.ToolStripButton();
            this.ForwardBtn = new System.Windows.Forms.ToolStripButton();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.HistoryBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.BookMarksBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.GoBtn = new System.Windows.Forms.ToolStripButton();
            this.HelpBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.processBar = new System.Windows.Forms.ToolStripProgressBar();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.BookMarksCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导航到主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向后ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.BookMarksCMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.收藏ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.DoubleClick += new System.EventHandler(this.menuStrip1_DoubleClick);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenUrl_MenuItem,
            this.OpenHtmlFile_MenuItem,
            this.SaveHtmlFile_MenuItem,
            this.AppExit_MenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // OpenUrl_MenuItem
            // 
            this.OpenUrl_MenuItem.Name = "OpenUrl_MenuItem";
            this.OpenUrl_MenuItem.Size = new System.Drawing.Size(124, 22);
            this.OpenUrl_MenuItem.Text = "打开网址";
            this.OpenUrl_MenuItem.Click += new System.EventHandler(this.打开网址ToolStripMenuItem_Click);
            // 
            // OpenHtmlFile_MenuItem
            // 
            this.OpenHtmlFile_MenuItem.Name = "OpenHtmlFile_MenuItem";
            this.OpenHtmlFile_MenuItem.Size = new System.Drawing.Size(124, 22);
            this.OpenHtmlFile_MenuItem.Text = "打开网页";
            // 
            // SaveHtmlFile_MenuItem
            // 
            this.SaveHtmlFile_MenuItem.Name = "SaveHtmlFile_MenuItem";
            this.SaveHtmlFile_MenuItem.Size = new System.Drawing.Size(124, 22);
            this.SaveHtmlFile_MenuItem.Text = "网页另存";
            // 
            // AppExit_MenuItem
            // 
            this.AppExit_MenuItem.Name = "AppExit_MenuItem";
            this.AppExit_MenuItem.Size = new System.Drawing.Size(124, 22);
            this.AppExit_MenuItem.Text = "退出";
            this.AppExit_MenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.视图ToolStripMenuItem.Text = "查看";
            // 
            // 收藏ToolStripMenuItem
            // 
            this.收藏ToolStripMenuItem.Name = "收藏ToolStripMenuItem";
            this.收藏ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.收藏ToolStripMenuItem.Text = "收藏";
            this.收藏ToolStripMenuItem.Click += new System.EventHandler(this.收藏ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryClear_MenuItem,
            this.ManageBookMarks_MenuItem,
            this.设置主页ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // HistoryClear_MenuItem
            // 
            this.HistoryClear_MenuItem.Name = "HistoryClear_MenuItem";
            this.HistoryClear_MenuItem.Size = new System.Drawing.Size(148, 22);
            this.HistoryClear_MenuItem.Text = "清理历史记录";
            this.HistoryClear_MenuItem.Click += new System.EventHandler(this.HistoryClearMenuItem_Click);
            // 
            // ManageBookMarks_MenuItem
            // 
            this.ManageBookMarks_MenuItem.Name = "ManageBookMarks_MenuItem";
            this.ManageBookMarks_MenuItem.Size = new System.Drawing.Size(148, 22);
            this.ManageBookMarks_MenuItem.Text = "管理书签";
            this.ManageBookMarks_MenuItem.Click += new System.EventHandler(this.ManageBookMarks_MenuItem_Click);
            // 
            // 设置主页ToolStripMenuItem
            // 
            this.设置主页ToolStripMenuItem.Name = "设置主页ToolStripMenuItem";
            this.设置主页ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设置主页ToolStripMenuItem.Text = "设置主页";
            this.设置主页ToolStripMenuItem.Click += new System.EventHandler(this.设置主页ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.HomeBtn,
            this.BackBtn,
            this.ForwardBtn,
            this.RefreshBtn,
            this.HistoryBtn,
            this.BookMarksBtn,
            this.toolStripTextBox1,
            this.GoBtn,
            this.HelpBtn});
            this.toolStrip1.Location = new System.Drawing.Point(1, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(994, 36);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.DoubleClick += new System.EventHandler(this.toolStrip1_DoubleClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Demo.Properties.Resources.快速链接;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 33);
            this.toolStripButton1.Text = "面板";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Image = global::Demo.Properties.Resources.主页;
            this.HomeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(52, 33);
            this.HomeBtn.Text = "主页";
            this.HomeBtn.ToolTipText = "主页";
            this.HomeBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::Demo.Properties.Resources.后退;
            this.BackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(52, 33);
            this.BackBtn.Text = "向后";
            this.BackBtn.ToolTipText = "向后";
            this.BackBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.Image = global::Demo.Properties.Resources.前进;
            this.ForwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(52, 33);
            this.ForwardBtn.Text = "向前";
            this.ForwardBtn.ToolTipText = "向前";
            this.ForwardBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::Demo.Properties.Resources.重新开始;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(52, 33);
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.ToolTipText = "刷新";
            this.RefreshBtn.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Image = global::Demo.Properties.Resources.菜单;
            this.HistoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(61, 33);
            this.HistoryBtn.Text = "历史";
            this.HistoryBtn.ToolTipText = "历史记录";
            this.HistoryBtn.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HistoryBtn_DropDownItemClicked);
            this.HistoryBtn.MouseEnter += new System.EventHandler(this.HistoryBtn_MouseEnter);
            // 
            // BookMarksBtn
            // 
            this.BookMarksBtn.Image = global::Demo.Properties.Resources.加入书签;
            this.BookMarksBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookMarksBtn.Name = "BookMarksBtn";
            this.BookMarksBtn.Size = new System.Drawing.Size(61, 33);
            this.BookMarksBtn.Text = "书签";
            this.BookMarksBtn.ToolTipText = "书签";
            this.BookMarksBtn.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BookMarksBtn_DropDownItemClicked);
            this.BookMarksBtn.Click += new System.EventHandler(this.BookMarksBtn_Click);
            this.BookMarksBtn.MouseEnter += new System.EventHandler(this.BookFalg_MouseEnter);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 36);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // GoBtn
            // 
            this.GoBtn.Image = global::Demo.Properties.Resources.存至网盘;
            this.GoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoBtn.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(52, 33);
            this.GoBtn.Text = "前往";
            this.GoBtn.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Image = global::Demo.Properties.Resources.书签;
            this.HelpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(52, 33);
            this.HelpBtn.Text = "帮助";
            this.HelpBtn.ToolTipText = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusTitle});
            this.statusStrip1.Location = new System.Drawing.Point(1, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(994, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusTitle
            // 
            this.StatusTitle.Name = "StatusTitle";
            this.StatusTitle.Size = new System.Drawing.Size(0, 17);
            // 
            // processBar
            // 
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(100, 16);
            this.processBar.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.ContextMenuStrip = this.BookMarksCMenu;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(1, 62);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(994, 470);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // BookMarksCMenu
            // 
            this.BookMarksCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导航到主页ToolStripMenuItem,
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.向前ToolStripMenuItem,
            this.向后ToolStripMenuItem});
            this.BookMarksCMenu.Name = "BookMarksCMenu";
            this.BookMarksCMenu.Size = new System.Drawing.Size(125, 114);
            this.BookMarksCMenu.MouseLeave += new System.EventHandler(this.BookMarksCMenu_MouseLeave);
            // 
            // 导航到主页ToolStripMenuItem
            // 
            this.导航到主页ToolStripMenuItem.Name = "导航到主页ToolStripMenuItem";
            this.导航到主页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导航到主页ToolStripMenuItem.Text = "返回主页";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aToolStripMenuItem.Text = "网页另存";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.bToolStripMenuItem.Text = "书签收藏";
            // 
            // 向前ToolStripMenuItem
            // 
            this.向前ToolStripMenuItem.Name = "向前ToolStripMenuItem";
            this.向前ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.向前ToolStripMenuItem.Text = "向前导航";
            // 
            // 向后ToolStripMenuItem
            // 
            this.向后ToolStripMenuItem.Name = "向后ToolStripMenuItem";
            this.向后ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.向后ToolStripMenuItem.Text = "向后导航";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 469);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 469);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(232, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "浏览历史";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "书签收藏";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 25);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(922, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "S";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(970, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(946, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "M";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(996, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.BookMarksCMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenUrl_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveHtmlFile_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppExit_MenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton HomeBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripButton BackBtn;
        private System.Windows.Forms.ToolStripButton ForwardBtn;
        private System.Windows.Forms.ToolStripDropDownButton BookMarksBtn;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton GoBtn;
        private System.Windows.Forms.ToolStripMenuItem OpenHtmlFile_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripButton HelpBtn;
        private System.Windows.Forms.ToolStripMenuItem HistoryClear_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageBookMarks_MenuItem;
        private System.Windows.Forms.ContextMenuStrip BookMarksCMenu;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusTitle;
        private System.Windows.Forms.ToolStripProgressBar processBar;
        private System.Windows.Forms.ToolStripMenuItem 导航到主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向后ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton HistoryBtn;
        private System.Windows.Forms.ToolStripMenuItem 设置主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip2;

    }
}


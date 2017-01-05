namespace EntityWebBrowser
{
    partial class BookMarkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OkBtt = new System.Windows.Forms.Button();
            this.canbtt = new System.Windows.Forms.Button();
            this.titleTxtbox = new System.Windows.Forms.TextBox();
            this.urlTxtbox = new System.Windows.Forms.TextBox();
            this.cataLogCbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "分类：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "标题：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "网址：";
            // 
            // OkBtt
            // 
            this.OkBtt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkBtt.Location = new System.Drawing.Point(43, 119);
            this.OkBtt.Name = "OkBtt";
            this.OkBtt.Size = new System.Drawing.Size(75, 23);
            this.OkBtt.TabIndex = 3;
            this.OkBtt.Text = "确定";
            this.OkBtt.UseVisualStyleBackColor = true;
            this.OkBtt.Click += new System.EventHandler(this.OkBtt_Click);
            // 
            // canbtt
            // 
            this.canbtt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.canbtt.Location = new System.Drawing.Point(161, 119);
            this.canbtt.Name = "canbtt";
            this.canbtt.Size = new System.Drawing.Size(75, 23);
            this.canbtt.TabIndex = 4;
            this.canbtt.Text = "取消";
            this.canbtt.UseVisualStyleBackColor = true;
            // 
            // titleTxtbox
            // 
            this.titleTxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTxtbox.Location = new System.Drawing.Point(68, 52);
            this.titleTxtbox.Name = "titleTxtbox";
            this.titleTxtbox.Size = new System.Drawing.Size(185, 21);
            this.titleTxtbox.TabIndex = 5;
            // 
            // urlTxtbox
            // 
            this.urlTxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.urlTxtbox.Location = new System.Drawing.Point(68, 82);
            this.urlTxtbox.Name = "urlTxtbox";
            this.urlTxtbox.Size = new System.Drawing.Size(185, 21);
            this.urlTxtbox.TabIndex = 6;
            // 
            // cataLogCbb
            // 
            this.cataLogCbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cataLogCbb.FormattingEnabled = true;
            this.cataLogCbb.Location = new System.Drawing.Point(68, 16);
            this.cataLogCbb.Name = "cataLogCbb";
            this.cataLogCbb.Size = new System.Drawing.Size(185, 20);
            this.cataLogCbb.TabIndex = 7;
            // 
            // BookMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 157);
            this.Controls.Add(this.cataLogCbb);
            this.Controls.Add(this.urlTxtbox);
            this.Controls.Add(this.titleTxtbox);
            this.Controls.Add(this.canbtt);
            this.Controls.Add(this.OkBtt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookMarkForm";
            this.Text = "书签收藏";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OkBtt;
        private System.Windows.Forms.Button canbtt;
        private System.Windows.Forms.TextBox titleTxtbox;
        private System.Windows.Forms.TextBox urlTxtbox;
        private System.Windows.Forms.ComboBox cataLogCbb;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class UrlForm : Form
    {
        public string Url { set; get; }

        public UrlForm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {           
            Url = this.textBox1.Text.Trim();
            if (string.IsNullOrEmpty(Url)) return;
            if (!Url.Contains("http://")) Url = "http://" + Url;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

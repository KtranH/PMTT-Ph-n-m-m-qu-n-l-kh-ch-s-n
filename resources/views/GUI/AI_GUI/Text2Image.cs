using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AI_GUI
{
    public partial class Text2Image : Form
    {
        public Text2Image()
        {
            InitializeComponent();
        }

        private void Text2Image_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
        private async Task innitizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await innitizated();
            webView21.CoreWebView2.Navigate("http://127.0.0.1:7860");
        }
    }
}

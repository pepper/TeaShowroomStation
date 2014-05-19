using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenSingleVideoForm_Click(object sender, EventArgs e)
        {
            SingleVideoForm singleVideoFrom = new SingleVideoForm();
            singleVideoFrom.Show();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }
    }
}

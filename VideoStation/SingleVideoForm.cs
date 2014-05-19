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
    public partial class SingleVideoForm : Form
    {
        public SingleVideoForm()
        {
            InitializeComponent();
        }

        private void SingleVideoForm_Load(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK){
//                axWindowsMediaPlayer1.uiMode = "none";
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if(e.nKeyCode == 27){
                this.Close();
            }
        }
    }
}

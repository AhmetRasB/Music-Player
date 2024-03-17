using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }

        private void sfButton3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void toggleButton1_Click(object sender, EventArgs e)
        {
            if (toggleButton1.ToggleState == ToggleButtonState.Inactive)
            {
                Player.Ctlcontrols.pause();             }
            else
            {
                Player.Ctlcontrols.play(); 
            }
        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void sfButton5_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.previous();
        }

        private void sfButton4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.next();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

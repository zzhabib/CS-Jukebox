using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS_Jukebox
{
    public partial class MainForm : Form
    {

        bool dirSelected = false;

        public MainForm()
        {
            InitializeComponent();

            //string startupPath = Directory.GetCurrentDirectory();
            //MessageBox.Show(startupPath);

            if (!dirSelected)
            {
                Form dirPopup = new GamePathForm();
                dirPopup.Show(this);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

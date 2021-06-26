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
    public partial class GamePathForm : Form
    {
        private bool dirValid = false;
        public GamePathForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dirTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private bool CheckDir(string path)
        {
            return File.Exists(path + @"\csgo.exe");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dirValid)
            {
                CreateConfig();
                Close();
            }
        }

        private void CreateConfig()
        {
            string configPath = Properties.GameDir + Properties.ConfigPath;
            string root = Directory.GetCurrentDirectory();
            string configSrc = root + Properties.ConfigName;

            if (File.Exists(configPath))
            {
                //File.Replace(configSrc, configPath, root + @"\configbackup.cfg");
                File.Delete(configPath);
                File.Copy(configSrc, configPath);
            }
            else
            {
                File.Copy(configSrc, configPath);
            }
        }

        private void dirTextBox_TextChanged(object sender, EventArgs e)
        {
            dirValid = CheckDir(dirTextBox.Text);
            if (dirValid)
            {
                Properties.GameDir = dirTextBox.Text;
                errorLabel.Visible = false;
                okButton.Enabled = true;
            }
            else
            {
                Properties.GameDir = null;
                errorLabel.Visible = true;
                okButton.Enabled = false;
            }
        }
    }
}

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
using CSGSI;
using CSGSI.Nodes;
using System.Runtime.InteropServices;

namespace CS_Jukebox
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private GameLogic logic;

        public MainForm()
        {
            InitializeComponent();
            AllocConsole(); //Enable console

            Properties.Load();
            
            //If game directory is not set, create
            //popup so that user can browse to it.
            if (Properties.GameDir == null)
            {
                Form dirPopup = new GamePathForm();
                dirPopup.ShowDialog(this);
            }

            Start();
        }

        void Start()
        {
            RefreshParameters();
            SetupGameListener();
        }

        void SetupGameListener()
        {
            Properties.CreateConfig();
            logic = new GameLogic();
        }

        //Refreshes controls that contain mutable data
        void RefreshParameters()
        {
            CreateKitDropdown();

            trackBar1.Value = Properties.MasterVolume;
        }

        private void CreateKitDropdown()
        {
            musicComboBox.Items.Clear();

            foreach (MusicKit musicKit in Properties.MusicKits)
            {
                musicComboBox.Items.Add(musicKit.Name);
            }

            if (Properties.SelectedKit != null)
                musicComboBox.SelectedIndex = Properties.MusicKits.IndexOf(Properties.SelectedKit);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Properties.MasterVolume = trackBar1.Value;
            logic.jukebox.UpdateVolume();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form musicSelector = new MusicSelector(new MusicKit(""), true);
            musicSelector.ShowDialog(this);
            RefreshParameters();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (Properties.SelectedKit != null)
            {
                Form musicSelector = new MusicSelector(Properties.SelectedKit, false);
                musicSelector.ShowDialog(this);
                RefreshParameters();
            }
        }

        private void musicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.SelectedKit = Properties.MusicKits[musicComboBox.SelectedIndex];
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Save();
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            Form dirPopup = new GamePathForm();
            dirPopup.ShowDialog(this);
            RefreshParameters();
        }
    }
}

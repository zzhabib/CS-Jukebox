using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

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
            MaximizeBox = false;

            Properties.Load();
            
            //If game directory is not set, create
            //popup so that user can browse to it.
            if (Properties.GameDir == null)
            {
                Form dirPopup = new GamePathForm();
                dirPopup.Location = this.Location;
                dirPopup.ShowDialog(this);
            }

            CheckAutoStart();
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

        private void CheckAutoStart()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            bool autoStart = registryKey.GetValue("CS-Jukebox") != null;
            autoCheckBox.Checked = autoStart;
        }

        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("CS-Jukebox", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("CS-Jukebox");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Properties.MasterVolume = trackBar1.Value;
            logic.jukebox.UpdateVolume();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form musicSelector = new MusicSelector(new MusicKit(""), true);
            musicSelector.Location = this.Location;
            musicSelector.ShowDialog(this);
            RefreshParameters();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (Properties.SelectedKit != null)
            {
                Form musicSelector = new MusicSelector(Properties.SelectedKit, false);
                musicSelector.Location = this.Location;
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
            dirPopup.Location = this.Location;
            dirPopup.ShowDialog(this);
            RefreshParameters();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void autoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RegisterInStartup(autoCheckBox.Checked);
        }
    }
}

using System;
using System.Windows.Forms;

namespace CS_Jukebox
{
    public partial class MusicSelector : Form
    {
        public delegate void RefreshHandler();

        MusicKit currentKit = null; //Music kit currently being edited
        bool createMode = false;
        RefreshHandler refreshHandler;

        //public MusicSelector()
        //{
        //    InitializeComponent();

        //    foreach (MusicKit musicKit in Properties.MusicKits)
        //    {
        //        musicComboBox.Items.Add(musicKit.Name);
        //    }

        //    currentKit = Properties.SelectedKit;
        //    musicComboBox.SelectedItem = currentKit;
        //}

        public MusicSelector(MusicKit newKit, RefreshHandler refreshHandler, bool? createKit)
        {
            InitializeComponent();

            if (createKit.HasValue) createMode = createKit.Value;

            currentKit = newKit;
            this.refreshHandler = refreshHandler;

            LoadKitParameters();
        }

        private void MusicSelector_Load(object sender, EventArgs e)
        {

        }

        private void LoadKitParameters()
        {
            nameTextBox.Text = currentKit.Name;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals(""))
            {
                //Show warning prompt
            }
            else
            {
                MusicKit newKit = new MusicKit(nameTextBox.Text);
                Properties.MusicKits.Add(newKit);
                currentKit = newKit;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Equals(""))
            {
                //Show warning prompt
            }
            else
            {
                currentKit.freezeSong = new SongProfile(freezeTextBox.Text, freezeTrackBar.Value);
                currentKit.startSong = new SongProfile(startTextBox.Text, startTrackBar.Value);
                currentKit.bombSong = new SongProfile(bombTextBox.Text, bombTrackBar.Value);
                currentKit.winSong = new SongProfile(wonTextBox.Text, wonTrackBar.Value);
                currentKit.loseSong = new SongProfile(lostTextBox.Text, lostTrackBar.Value);
                currentKit.MVPSong = new SongProfile(MVPTextBox.Text, MVPTrackBar.Value);

                if (createMode)
                {
                    //Add kit to list if it is a new kit
                    currentKit.Name = nameTextBox.Text;
                    Properties.MusicKits.Add(currentKit);
                    Properties.SelectedKit = currentKit;
                }
                else if (nameTextBox.Text != currentKit.Name)
                {
                    //Detect if a music kit was renamed
                    Properties.DeleteKitFile(currentKit.Name);
                    currentKit.Name = nameTextBox.Text;
                }

                Properties.SaveKits();

                //Add some form of delegate method to invoke in MainForm.cs
                refreshHandler.Invoke();
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            refreshHandler.Invoke();
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this kit?", "Delete Music Kit", MessageBoxButtons.YesNo);

            if (createMode)
            {
                refreshHandler.Invoke();
                Close();
            }

            if (confirmResult == DialogResult.Yes)
            {
                Properties.DeleteKitFile(currentKit.Name);
                Properties.MusicKits.Remove(currentKit);
                Properties.SaveKits();

                refreshHandler.Invoke();
                Close();
            }
        }
    }
}

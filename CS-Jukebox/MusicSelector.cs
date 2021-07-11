using System;
using System.Windows.Forms;

namespace CS_Jukebox
{
    public partial class MusicSelector : Form
    {

        MusicKit currentKit = null; //Music kit currently being edited

        public MusicSelector()
        {
            InitializeComponent();

            foreach (MusicKit musicKit in Properties.MusicKits)
            {
                musicComboBox.Items.Add(musicKit.Name);
            }

            currentKit = Properties.SelectedKit;
            musicComboBox.SelectedItem = currentKit;
        }

        private void MusicSelector_Load(object sender, EventArgs e)
        {

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
                musicComboBox.Items.Add(newKit.Name);
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

                //Detect if a music kit was renamed
                if (nameTextBox.Text != currentKit.Name)
                {
                    Properties.DeleteKitFile(currentKit.Name);
                    currentKit.Name = nameTextBox.Text;
                }

                Properties.SaveKits();

                //Add some form of delegate method to invoke in MainForm.cs
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void musicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameTextBox.Text = musicComboBox.Text;
            currentKit = Properties.MusicKits[musicComboBox.SelectedIndex];
        }
    }
}

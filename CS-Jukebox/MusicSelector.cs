using System;
using System.Windows.Forms;

namespace CS_Jukebox
{
    public partial class MusicSelector : Form
    {
        MusicKit currentKit = null; //Music kit currently being edited
        bool createMode = false;

        public MusicSelector(MusicKit newKit, bool? createKit)
        {
            InitializeComponent();

            if (createKit.HasValue) createMode = createKit.Value;
            currentKit = newKit;

            LoadKitParameters();
        }

        private void MusicSelector_Load(object sender, EventArgs e)
        {

        }

        //Loads parameters into controls such as textboxes and trackbars
        private void LoadKitParameters()
        {
            nameTextBox.Text = currentKit.Name;

            freezeTextBox.Text = currentKit.freezeSong.Path;
            startTextBox.Text = currentKit.startSong.Path;
            bombTextBox.Text = currentKit.bombSong.Path;
            wonTextBox.Text = currentKit.winSong.Path;
            lostTextBox.Text = currentKit.loseSong.Path;
            MVPTextBox.Text = currentKit.MVPSong.Path;

            freezeTrackBar.Value = currentKit.freezeSong.Volume;
            startTrackBar.Value = currentKit.startSong.Volume;
            bombTrackBar.Value = currentKit.bombSong.Volume;
            wonTrackBar.Value = currentKit.winSong.Volume;
            lostTrackBar.Value = currentKit.loseSong.Volume;
            MVPTrackBar.Value = currentKit.MVPSong.Volume;

            freezeStartTextBox.Text = currentKit.freezeSong.Start.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                //Show warning prompt
                MessageBox.Show("Please enter a name.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                //currentKit.freezeSong = new SongProfile(freezeTextBox.Text, freezeTrackBar.Value);
                currentKit.freezeSong = GetSongFromParams(freezeTextBox, freezeTrackBar, freezeStartTextBox);
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

                Properties.Save();

                //Add some form of delegate method to invoke in MainForm.cs
                Close();
            }
        }

        //Returns a new SongProfile based on values of given form controls
        private SongProfile GetSongFromParams(TextBox pathTextBox, TrackBar volumeTrackbar, TextBox startTextBox)
        {
            SongProfile newSong = new SongProfile(pathTextBox.Text, volumeTrackbar.Value);
            newSong.Start = startTextBox.Enabled ? int.Parse(startTextBox.Text) : 0;
            return newSong;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this kit?", "Delete Music Kit", MessageBoxButtons.YesNo);

            if (createMode)
            {
                Close();
            }

            if (confirmResult == DialogResult.Yes)
            {
                Properties.DeleteKitFile(currentKit.Name);
                Properties.MusicKits.Remove(currentKit);
                Properties.SaveKits();

                Close();
            }
        }

        //Click handlers for browse buttons

        private void OpenSongFile(TextBox textBox)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openFileDialog1.FileName;
            }
        }

        private void freezeButton_Click(object sender, EventArgs e)
        {
            OpenSongFile(freezeTextBox);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            OpenSongFile(startTextBox);
        }

        private void bombButton_Click(object sender, EventArgs e)
        {
            OpenSongFile(bombTextBox);
        }

        private void wonButton_Click(object sender, EventArgs e)
        {
            OpenSongFile(wonTextBox);
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            OpenSongFile(lostTextBox);
        }

        private void MVPButton_Click(object sender, EventArgs e)
        {
            OpenSongFile(MVPTextBox);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

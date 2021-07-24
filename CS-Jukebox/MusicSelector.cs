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

            SetParamsFromSong(currentKit.freezeSong, freezeTextBox, freezeTrackBar, freezeStartTextBox);
            SetParamsFromSong(currentKit.startSong, startTextBox, startTrackBar, startStartTextBox);
            SetParamsFromSong(currentKit.bombSong, bombTextBox, bombTrackBar, bombStartTextBox);
            SetParamsFromSong(currentKit.winSong, wonTextBox, wonTrackBar, wonStartTextBox);
            SetParamsFromSong(currentKit.loseSong, lostTextBox, lostTrackBar, lostStartTextBox);
            SetParamsFromSong(currentKit.MVPSong, MVPTextBox, MVPTrackBar, MVPStartTextBox);
            SetParamsFromSong(currentKit.bombTenSecSong, bombTenSecTextBox, bombTenSecTrackBar, bombTenSecStartBox);
            SetParamsFromSong(currentKit.roundTenSecSong, roundTenSecTextBox, roundTenSecTrackBar, roundTenSecStartBox);
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
                currentKit.freezeSong = GetSongFromParams(freezeTextBox, freezeTrackBar, freezeStartTextBox);
                currentKit.startSong = GetSongFromParams(startTextBox, startTrackBar, startStartTextBox);
                currentKit.bombSong = GetSongFromParams(bombTextBox, bombTrackBar, bombStartTextBox);
                currentKit.winSong = GetSongFromParams(wonTextBox, wonTrackBar, wonStartTextBox);
                currentKit.loseSong = GetSongFromParams(lostTextBox, lostTrackBar, lostStartTextBox);
                currentKit.MVPSong = GetSongFromParams(MVPTextBox, MVPTrackBar, MVPStartTextBox);
                currentKit.bombTenSecSong = GetSongFromParams(bombTenSecTextBox, bombTenSecTrackBar, bombTenSecStartBox);
                currentKit.roundTenSecSong = GetSongFromParams(roundTenSecTextBox, roundTenSecTrackBar, roundTenSecStartBox);

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

        //Sets parameters of controls from song
        private void SetParamsFromSong(SongProfile songProfile,
                                       TextBox pathTextBox,
                                       TrackBar volumeTrackbar,
                                       TextBox startTextBox)
        {
            pathTextBox.Text = songProfile.Path;
            volumeTrackbar.Value = songProfile.Volume;
            startTextBox.Text = songProfile.Start.ToString();
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

        private void bombTenSecButton_Click(object sender, EventArgs e)
        {
            OpenSongFile(bombTenSecTextBox);
        }

        private void roundTenSecButton_Click(object sender, EventArgs e)
        {
            OpenSongFile(roundTenSecTextBox);
        }

        private void freezeStartTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void startStartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bombStartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void wonStartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lostStartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void MVPStartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bombTenSecStartBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void roundTenSecStartBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace CS_Jukebox
{
    public class Jukebox
    {
        private WindowsMediaPlayer player;
        private SongProfile currentSong;

        private Timer songTimer;
        private Timer fadeTimer;

        public Jukebox()
        {
            player = new WindowsMediaPlayer();
            SetupTimers();
        }

        public void PlaySong(string path)
        {
            player.URL = path;
            player.controls.play();
        }

        public void PlaySong(SongProfile song, bool loop)
        {
            float volume = ((float)Properties.MasterVolume / 100) * (float)song.Volume;
            currentSong = song;

            player.settings.volume = (int)volume;
            player.URL = song.Path;
            player.controls.play();
            player.settings.setMode("loop", loop);
        }

        public void PlaySong(SongProfile song, bool loop, int duration)
        {
            float volume = ((float)Properties.MasterVolume / 100) * (float)song.Volume;
            currentSong = song;

            player.settings.volume = (int)volume;
            player.URL = song.Path;
            player.controls.play();
            player.settings.setMode("loop", loop);
        }

        public void UpdateVolume()
        {
            float volume = ((float)Properties.MasterVolume / 100) * (float)currentSong.Volume;
            player.settings.volume = (int)volume;
        }

        private void SetupTimers()
        {
            Timer songTimer = new Timer();
            Timer fadeTimer = new Timer();
        }
    }
}

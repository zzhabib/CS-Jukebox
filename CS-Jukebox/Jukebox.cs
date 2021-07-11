using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;

namespace CS_Jukebox
{
    public class Jukebox
    {
        private WindowsMediaPlayer player;

        public Jukebox()
        {
            player = new WindowsMediaPlayer();
        }

        public void PlaySong(string path)
        {
            player.URL = path;
            player.controls.play();
        }

        public void PlaySong(SongProfile song)
        {
            player.URL = song.Path;
            player.controls.play();
        }

        public void SetVolume(int vol)
        {
            player.settings.volume = vol;
        }
    }
}

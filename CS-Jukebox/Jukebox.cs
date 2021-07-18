using System;
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

        private bool isPlaying = false;
        private int timerCount = 0;
        private int timerGoal = 0;
        private float fadeVolume;
        private float volumeIncrement; //Incremental change in volume when fading out song.

        public Jukebox()
        {
            player = new WindowsMediaPlayer();

            SetupTimer();
        }

        public void PlaySong(string path)
        {
            player.URL = path;
            player.controls.play();
        }

        //Play song for length or loop indefinitely
        public void PlaySong(SongProfile song, bool loop)
        {
            float volume = ((float)Properties.MasterVolume / 100) * (float)song.Volume;
            currentSong = song;

            player.settings.volume = (int)volume;
            player.URL = song.Path;
            player.controls.currentPosition = song.Start;
            player.controls.play();
            player.settings.setMode("loop", loop);
        }

        //Play song with a determined amount of time in seconds
        public void PlaySong(SongProfile song, bool loop, int duration)
        {
            PlaySong(song, loop);

            timerCount = 0;
            timerGoal = duration;
            isPlaying = true;
        }

        public void UpdateVolume()
        {
            float volume = ((float)Properties.MasterVolume / 100) * currentSong.Volume;
            player.settings.volume = (int)volume;
        }

        private void StopSong()
        {
            int fadeTime = 2;
            float startVolume = player.settings.volume;
            fadeVolume = startVolume;
            volumeIncrement = startVolume / ((1000 / 8) * fadeTime);
            
            timerCount = 0;

            fadeTimer = new Timer();
            fadeTimer.Interval = 8;
            fadeTimer.Tick += new EventHandler(FadeTimerTick);
            fadeTimer.Start();
        }

        private void FadeTimerTick(object sender, EventArgs e)
        {
            if (fadeVolume > 0)
            {
                fadeVolume -= volumeIncrement;
                player.settings.volume = (int)fadeVolume;
            }
            else
            {
                player.controls.stop();
                fadeTimer.Stop();
                isPlaying = false;
            }
        }

        private void SetupTimer()
        {
            Timer secondTimer = new Timer();
            secondTimer.Interval = 1000;
            secondTimer.Tick += new EventHandler(TimerTick);
            secondTimer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timerCount += 1;

            if (isPlaying && timerCount >= timerGoal)
            {
                StopSong();
            }
        }
    }
}

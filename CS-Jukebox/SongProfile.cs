using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Jukebox
{
    //Contains reference to the path of a song and saves volume
    public class SongProfile
    {
        public string Path;
        public int Volume;
        public int Start;

        public SongProfile()
        {
            Path = "";
            Volume = 100;
        }

        public SongProfile(string path, int volume)
        {
            Path = path;
            Volume = volume;
        }
    }
}

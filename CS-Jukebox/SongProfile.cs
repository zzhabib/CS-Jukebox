using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Jukebox
{
    //Contains reference to the path of a song and saves volume
    class SongProfile
    {
        public string Path;
        public int Volume;

        public SongProfile(string path, int volume)
        {
            Path = path;
            Volume = volume;
        }
    }
}

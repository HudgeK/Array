using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Song
    {
        public string Title;
        public string Artist;
        public string Album;
        public Song()
        {
            Title = "Unkown";
            Artist = "Unknown";
            Album = "Unkown";
        }
        public Song(string title, string artist, string album)
        {
            Title = title;
            Artist = artist;
            Album = album;
        }
    }
}

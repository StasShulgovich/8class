using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8class
{
    public class Song
    {
        public string SongName { get; set; }

        public Song(string Name)
        {
            this.SongName = Name;
        }

        public Song() {}
    }
}

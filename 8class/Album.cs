using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8class
{
    public class Album
    {
        private readonly List<Song> album = new List<Song>();

        public Album()
        {
            album.Add(new Song("Zolotie kupola"));
            album.Add(new Song("Devocka-Kepo4ka"));
            album.Add(new Song("Parickmaxer d9d9 Tolik"));
            album.Add(new Song("Its' my life"));
            album.Add(new Song("Sorry for party rocking"));
        }

        public Song this[int index]
        {
            get { return album[index]; }
            set { album[index] = value; }  
        }

        public void PlayAll()
        {
            Console.WriteLine("These songs are in the album:");
            foreach (var song in album)
            {
                Console.WriteLine(song.SongName);
            }
            Console.WriteLine(String.Empty);
        }


        public void PlayFrom(int index1)
        {
            for (int i = index1; i < album.Count; i++)
            {                
             Console.WriteLine(album[i].SongName);             
            }
            Console.WriteLine(String.Empty);
        }

        public void PlayFromTo(int index1, int index2)
        {
            for (int i = index1; i < index2; i++)
            {
               Console.WriteLine(album[i].SongName);                               
            }
            Console.WriteLine(String.Empty);
        }
        
        // передача песен через конструктор и коллекцию в альбом
        public Album(List<Song> songs)
        {
            album.AddRange(songs);
            //album = album.Skip(5).ToList();
            //album = album.Take(4).ToList();
        }     
              
        // передача песен через параметры в альбом
        public void AddSongs(List<Song> songs)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                album.Add(songs[i]);
            }
        }       
    }
}

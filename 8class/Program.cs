using System;


namespace _8class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conditions
            //            1.Создать класс Песня.
            //2.Создать класс Альбом
            //3.В классе Альбом реализовать добавление песен.
            //a.Добавить возможность создавать альбом не передавая параметры и передавая коллекцию песен.
            //4.В классе Альбом реализовать индексатор.
            //5.Используя индексатор в классе Альбом реализовать методы в классе программы:
            //            a.Play() – Вывести все песни.
            //          b.Play(from) – воспроизвести песни начиная с.
            //c.Play(from, to) – воспроизвести песни от до.

            #endregion

            #region FirstLevel
            //Song song1 = new Song("Grafin4ik vodocki");
            //Song song2 = new Song("Ne ostupat i ne sdavatsia");
            //Song song3 = new Song("a xui tam ne");

            //List<Song> songsCollection = new List<Song>()
            //{
            //    song1,
            //    song2
            //};

            //List<Song> songsCollection2 = new List<Song>()
            //{
            //    song3
            //};

            ////добавление песен в альбом через конструктор 
            //Album albumObject = new Album(songsCollection);
            //albumObject.ShowSongs();

            //Album albumDefault = new Album();
            //albumDefault.AddSongs(songsCollection2);
            //albumDefault.ShowSongs();
            #endregion

            Album playRecords = new Album();

          playRecords.PlayAll();

          playRecords.PlayFromTo(2, 3);
          
          playRecords.PlayFrom(1);            
          
          Console.ReadLine();
        }
    }  
}

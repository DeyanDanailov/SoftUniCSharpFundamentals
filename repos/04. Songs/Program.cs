using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                
                playlist.Add(Song.ReadSong(input));
            }
            string lastCommand = Console.ReadLine();
            if (lastCommand=="all")
            {
                for (int i = 0; i < playlist.Count; i++)
                {
                    Console.WriteLine(playlist[i].Name);
                }
            }
            else
            {
                List<Song> filteredSongs = playlist.Where(s => s.TypeList == lastCommand).ToList();
                for (int i = 0; i < filteredSongs.Count; i++)
                {
                    Console.WriteLine(filteredSongs[i].Name);
                }
            }


        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public static Song ReadSong(string input)
        {
           List<string> current = input.Split('_').ToList();
            Song someSong = new Song(current[0], current[1], current[2]);
            return someSong;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}

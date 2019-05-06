using System;
using System.IO;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"SampleMusicPlaylist.txt";

            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            Console.WriteLine("File name: {0}", fullPath);
       
          // System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(fileName);



            //2 Method to answers questions

            Console.Write("How many songs received 200 or more plays?");

            //var playsover200 = fileName.Where(lines => (lines.Plays >= 200.00));

            var lines = File.ReadAllLines("SampleMusicPlaylist.txt");

                for (int i = 200; i < lines.Length; i++)
                {
                    var fields = lines[i];
                }

            for (int j = 0; j < 40; j++)
            {
                for (int k = 0; k < 30; k++)
                {
                    Console.WriteLine(lines[j][k]);
                }
            }


        }
    }
}

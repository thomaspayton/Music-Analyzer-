/*using System;
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

            Console.Write("How many songs received 200 or more plays?");

            var lines = File.ReadAllLines("SampleMusicPlaylist.txt");

            for (int i = 200; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
            }

            for (int j = 0; j < 40; j++)
            {
                for (int k = 0; k < 30; k++)
                {
                    Console.WriteLine(lines[j][k]);
                }
            }
        }

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("MusicPlaylistAnalyzer <music_playlist_file_path> <report_file_path>");
                Environment.Exit(1);
            }

            string txtDataFilePath = args[0];
            string questionsFilePath = args[1];

            List<MusicPlaylist> MusicPlay = null;
            try
            {
                MusicPlay = MusicLoader.Load(txtDataFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(2);
            }

            var questions = Questions.GenerateText(MusicPlay);

            Console.WriteLine(questions);

            try
            {
                System.IO.File.WriteAllText(questionsFilePath, questions);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(3);
            }
        }
    }
}


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


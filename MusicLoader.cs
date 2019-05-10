using System;
using System.Collections.Generic;
using System.IO;

namespace MusicPlaylistAnalyzer
{
    public static class MusicLoader
    {
        private static int NumItemsInRow = 8;

        public static List<MusicPlaylist> Load(string txtDataFilePath)
        {
            List<MusicPlaylist> MusicPlay = new List<MusicPlaylist>();

            try
            {
                using (var reader = new StreamReader(txtDataFilePath))
                {
                    int lineNumber = 0;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        Console.WriteLine(line);
                        lineNumber++;
                        if (lineNumber == 1) continue;

                        var values = line.Split("\t");

                        if (values.Length != NumItemsInRow)
                        {
                            throw new Exception($"Row {lineNumber} contains {values.Length} values. It should contain {NumItemsInRow}.");
                        }
                        try
                        {
                            //SampleMusicPlaylist.txt output.txt
                            String Name = values[0];
                            String Artist = values[1];
                            String Album = values[2];
                            String Genre = values[3];
                            int Size = Int32.Parse(values[4]);
                            int Time = Int32.Parse(values[5]);
                            int Year = Int32.Parse(values[6]);
                            int Play = Int32.Parse(values[7]);
                            MusicPlaylist musicPlaylist = new MusicPlaylist(Name, Artist, Album, Genre, Size, Time, Year, Play);
                            MusicPlay.Add(musicPlaylist);
                        }
                        catch (FormatException e)
                        {
                            throw new Exception($"Row {lineNumber} contains invalid data. ({e.Message})");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to open {txtDataFilePath} ({e.Message}).");
            }

            return MusicPlay;
        }
    }
}
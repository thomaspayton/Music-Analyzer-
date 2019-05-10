using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MusicPlaylistAnalyzer
{
    public static class Questions
    {
        public static string GenerateText(List<MusicPlaylist> MusicPlay)
        {
            string questions = "Questions\n\n\n";

            if (MusicPlay.Count() < 1)
            {
                questions += "No data is available.\n";

                return questions;
            }
            /*
            var startSong = (from MusicPlaylist in MusicPlay select MusicPlaylist.Name).Min();
            var endSong = (from MusicPlaylist in MusicPlay select MusicPlaylist.Name).Max();


            questions += "How many songs received 200 or more plays: ";
            var songs = from MusicPlaylist in MusicPlay where MusicPlaylist.Plays < 200 select MusicPlaylist.Name;
            if (songs.Count() > 0)
            {
                foreach (var Name in songs)
                {
                    questions += songs + ",";
                }
                questions.TrimEnd(',');
                questions += "\n";
            }
            else
            {
                questions += "not available\n";
            }
            
            questions += "How many songs are in the playlist with the Genre of Alternative? ";

            var AtlGenre = from MusicPlaylist in MusicPlay where MusicPlaylist.Genre == Alternative select (MusicPlaylist.Genre);
            if (AtlGenre.Count() > 0)
            {
                questions += AtlGenre.First();
                questions += "\n";
            }

            questions += "How many songs are in the playlist with the Genre of Hip-Hop/Rap? ";

            var RapGenre = from MusicPlaylist in MusicPlay where MusicPlaylist.Genre == Hip-Hop/Rap select (MusicPlaylist.Genre);
            if (RapGenre.Count() > 0)
            {
                questions += RapGenre.First();
                questions += "\n";
            }

            questions += "What songs are in the playlist from the album Welcome to the Fishbowl? ";
            questions += "What are the songs in the playlist from before 1970? ";
            questions += "What are the song names that are more than 85 characters long? ";

            questions += "What is the longest song? ";
            var longestsong = from MusicPlaylist in MusicPlay where MusicPlaylist.Name == ((from time in MusicPlay select time.Time).Max()) select crimeStats.Year;
            if (yearMaxMotorVehicleThefts.Count() > 0)
            {
                report += yearMaxMotorVehicleThefts.First();
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }

            return questions;
        }
    }
}
*/
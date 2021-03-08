using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWorldCupLibrary
{
    public class Game
    {
        public string HomeTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public string AwayTeam { get; set; }
        public int AwayTeamScore { get; set; }

        public Game(string homeTeam, int homeTeamScore, string awayTeam, int awayTeamScore)
        {
            HomeTeam = homeTeam;
            HomeTeamScore = homeTeamScore;
            AwayTeam = awayTeam;
            AwayTeamScore = awayTeamScore;
        }

        public Game()
        {
        }
    }
}

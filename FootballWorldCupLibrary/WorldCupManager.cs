using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWorldCupLibrary
{
    public class WorldCupManager: IInitSummary, ICupManager
    {
        //Function to get a random number 
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
        public int UpdateScore(int startValue)
        {
            //int currentScore = new Random().Next(startValue, 10);
            int currentScore = RandomNumber(startValue, 10);

            return currentScore;
        }

        public void FinishGame(Game game, List<Game> summary)
        {
            summary.Add(game);
        }

        public List<Game> InitSummary()
        {
            List<Game> initialSummary = new List<Game>();
            initialSummary.Add(new Game("Uruguay", 6, "Italy", 6));
            initialSummary.Add(new Game("Spain", 10, "Brazil", 2));
            initialSummary.Add(new Game("Mexico", 0, "Canada", 5));
            initialSummary.Add(new Game("Argentina", 3, "Australia", 1));
            initialSummary.Add(new Game("Germany", 2, "France", 2));
            return initialSummary;
        }
    }
}

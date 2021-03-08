using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballWorldCupLibrary;

namespace WorldCupLibraryTestProject
{
    [TestClass]
    public class WorldCupLibraryTest
    {
        
        [TestMethod]
        public void TestInitSummary()
        {
            // Arrange
            WorldCupManager wm = new WorldCupManager();

            List<Game> testSummary = new List<Game>();
            testSummary.Add(new Game("Uruguay", 6, "Italy", 6));
            testSummary.Add(new Game("Spain", 10, "Brazil", 2));
            testSummary.Add(new Game("Mexico", 0, "Canada", 5));
            testSummary.Add(new Game("Argentina", 3, "Australia", 1));
            testSummary.Add(new Game("Germany", 2, "France", 2));

            // Act
            List<Game> actualSummary = wm.InitSummary();

            // Assert
            Assert.AreEqual(expected: actualSummary.Count(), testSummary.Count(), "List filled in wrong manner!");

        }

        [TestMethod]
        public void UpdateScoreTest()
        {
            // Arrange
            WorldCupManager wm = new WorldCupManager();
            int testScore = new Random().Next(5, 10);
            bool testScoreBool = true;
            if (testScore <= 10 && testScore >= 5)
            {
                testScoreBool = true;
            }
            else
            {
                testScoreBool = false;
            }


            // Act
            int actualScore = wm.UpdateScore(5);
            bool actualScoreBool = true;
            if (actualScore <= 10 && testScore >= 5 )
            {
                actualScoreBool = true;
            }
            else
            {
                actualScoreBool = false;
            }

            // Assert
            Assert.AreEqual(expected: actualScoreBool, testScoreBool, "Update scores generated in wrong manner!");
        }

        [TestMethod]
        public void FinishGameTest()
        {
            // Arrange
            WorldCupManager wm = new WorldCupManager();
            List<Game> testSummary = new List<Game>();
            testSummary.Add(new Game("Uruguay", 6, "Italy", 6));
            testSummary.Add(new Game("Spain", 10, "Brazil", 2));
            testSummary.Add(new Game("Mexico", 0, "Canada", 5));
            testSummary.Add(new Game("Argentina", 3, "Australia", 1));
            testSummary.Add(new Game("Germany", 2, "France", 2));
            Game actualGame = new Game("HomeTeam", 5, "AwayTeam", 5);
            testSummary.Add(actualGame);

            // Act
            List<Game> actualSummary = wm.InitSummary();
            Game testGame = new Game("HomeTeam", 5, "AwayTeam", 5);
            wm.FinishGame(testGame, actualSummary);

            // Assert
            Assert.AreEqual(expected: actualSummary.Count(), testSummary.Count(), "Finish Game works in wrong manner!");


        }
    }
}

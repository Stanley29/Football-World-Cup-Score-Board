using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballWorldCupLibrary;

namespace ScoreBoard
{
    class Program
    {
        
        static void Main(string[] args)
        { 
            Menu m = new Menu();
            MainMenu mm = new MainMenu(m);
            WorldCupManager wm = new WorldCupManager();
            List<Game> summaryWorldCup = new List<Game>();
            summaryWorldCup = wm.InitSummary();
            //ShoppingManager sm = new ShoppingManager();

            do
            {
                mm.DoStart();
                switch (mm.Choice)
                {
                    case 1://get items list
                        
                        GameMenu gm = new GameMenu();
                        MainMenu gmm = new MainMenu(gm);
                        Game newGame = new Game();
                        bool gameFinished = false;
                        bool gameStarted = false;
                        do
                        {
                            gmm.DoStart();
                            switch (gmm.Choice)
                            {
                                case 1:
                                    Console.WriteLine("Start game!");
                                    if (!gameStarted)
                                    {
                                        Console.WriteLine("Please, input the Home Team:");
                                        string homeTeamName = Console.ReadLine();
                                        Console.WriteLine("Please, input the Away Team:");
                                        string awayTeamName = Console.ReadLine();
                                        //Game newGame = new Game(homeTeamName, 0, awayTeamName, 0);
                                        newGame.HomeTeam = homeTeamName;
                                        newGame.AwayTeam = awayTeamName;
                                        newGame.HomeTeamScore = 0;
                                        newGame.AwayTeamScore = 0;
                                        gameStarted = true;
                                        gameFinished = false;
                                        Console.WriteLine("Current Game Status:");
                                        Console.Write(newGame.HomeTeam + " -");
                                        Console.Write(newGame.AwayTeam + ":");
                                        Console.Write(newGame.HomeTeamScore.ToString() + " - " + newGame.AwayTeamScore.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Game is started already! Please, finish the current game first...");
                                    }
                                    
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Update Score");
                                    if (gameStarted)
                                    {
                                        if (!gameFinished)
                                        {
                                            Console.WriteLine("To Update Score press any key...");
                                            Console.ReadKey();
                                            int curScoreHome = wm.UpdateScore(newGame.HomeTeamScore);
                                            newGame.HomeTeamScore = curScoreHome;
                                            int curScoreAway = wm.UpdateScore(newGame.AwayTeamScore);
                                            newGame.AwayTeamScore = curScoreAway;
                                            Console.WriteLine("Current Game Status:");
                                            Console.Write(newGame.HomeTeam + " -");
                                            Console.Write(newGame.AwayTeam + ":");
                                            Console.Write(newGame.HomeTeamScore.ToString() + " - " + newGame.AwayTeamScore.ToString());
                                        }
                                        else
                                        {
                                            Console.WriteLine("Game is finished already! Update is not available at the moment...");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Game is not started yet! Please, start the game first...");
                                    }
                                    
                                    
                                    Console.ReadKey();

                                    break;
                                case 3:
                                    Console.WriteLine("Finish Game");
                                    if (gameStarted)
                                    {
                                        Console.WriteLine("To Finish the Game press any key...");
                                        Console.ReadKey();
                                        gameFinished = true;
                                        gameStarted = false;
                                        Console.WriteLine("Final Game Status:");
                                        Console.Write(newGame.HomeTeam + " -");
                                        Console.Write(newGame.AwayTeam + ":");
                                        Console.Write(newGame.HomeTeamScore.ToString() + " - " + newGame.AwayTeamScore.ToString());
                                        wm.FinishGame(newGame, summaryWorldCup);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Game is not started yet! Please, start the game first...");
                                    }
                                    
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    break;

                                default:
                                    break;
                            }

                            if (gmm.Choice == 6)
                            {
                                break;
                            }
                        } while (gmm.DoAllowContinue());
                        gmm.DoFinish();

                        Console.WriteLine("Task completed succesfully!");
                        Console.ReadKey();
                        break;
                    case 2://get item
                        Console.WriteLine("Summary of games by total score");
                        foreach (var item in summaryWorldCup)
                        {
                            Console.Write(item.HomeTeam + " " + item.HomeTeamScore.ToString() + " - ");
                            Console.Write(item.AwayTeam + " " + item.AwayTeamScore.ToString());
                            Console.WriteLine();
                        }

                        break;
                    
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                if (mm.Choice == 6)
                {
                    break;
                }

            } while (mm.DoAllowContinue());
            mm.DoFinish();
        }
    }
}

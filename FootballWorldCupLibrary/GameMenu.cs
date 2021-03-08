using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWorldCupLibrary
{
    public class GameMenu : Menu
    {
        public override void Start()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\n\t =====================");
            Console.WriteLine("\n\t Football Game Menu");
            Console.WriteLine("\n\t =====================");
            Console.WriteLine("\n\t =");
            Console.WriteLine("\t 1: Start Game");
            Console.WriteLine("\t 2: Update score ");
            Console.WriteLine("\t 3: Finish game ");


            Console.WriteLine("\t 6: Exit to Main Menu");
            Console.WriteLine("\n\t =====================");
            Console.WriteLine("\n\t Please, make your choice");
            try
            {
                Choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine("{0} - error of the menu option choice!", err.Message);
            }

        }

        public override void Finish()
        {
            Console.WriteLine("\nGame finished");
        }

        public override bool AllowContinue()
        {
            Console.Write("\n Continue Game (y/n)? - ");
            Ans = Console.ReadLine();
            return (Ans == "y");

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWorldCupLibrary
{
    public class Menu : IMenu
    {
        public string Ans { get; set; }
        public int Choice { get; set; }
        public virtual void Start()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\n\t =====================");
            Console.WriteLine("\n\t Football World Cup Score Board");
            Console.WriteLine("\n\t =====================");
            Console.WriteLine("\n\t =");
            Console.WriteLine("\t 1: Start Game"); 
            Console.WriteLine("\t 2: Get a summary of games by total score ");


            Console.WriteLine("\t 6: Exit");
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

        public virtual void Finish()
        {
            Console.WriteLine("\nProgram finished");
        }

        public virtual bool AllowContinue()
        {
            Console.Write("\n Continue (y/n)? - ");
            Ans = Console.ReadLine();
            return (Ans == "y");
            
        }

        public bool AllowLoop()
        {
            Console.Write("\n Break the loop(y)? - \n");
            return true;

        }
    }
}

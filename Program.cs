using System;
using System.ComponentModel;

namespace AirConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        { bool menuSelection = false;
         do{
                Console.WriteLine("\n********************************");
                Console.WriteLine("**   Welcome to AirConsole    **");
                Console.WriteLine("********************************");

                Console.WriteLine("\nTask Selection");
                Console.WriteLine("R: Reservation");
                Console.WriteLine("S: Seat Verification");
                Console.WriteLine("X: Exit the System");

                Console.Write("\nPlease enter the task you want to perform: ");

                string selection = Console.ReadLine().ToUpper();


                if (selection == "R")
                {
                    menuSelection= true;
                    ReserveSeat.SelectSeat();
                    MainMenuReturn.ReturnToMainMenu();
                }

                if (selection == "S")
                {
                    menuSelection= true;
                    VerifySeat.VerifySelectedSeat();
                    MainMenuReturn.ReturnToMainMenu();
                }

                if (selection == "X")
                {
                     menuSelection= true;
                    Console.WriteLine("\nSession Complete. Goodbye!\n");
                    Environment.Exit(0);
                }
                if (selection !="R" || selection!="S" || selection!="X")
                {
                    menuSelection=false;
                    Console.WriteLine("\nInvalid entry. Please try again.");
                }
            }while(!menuSelection);
        }

       
    }
}

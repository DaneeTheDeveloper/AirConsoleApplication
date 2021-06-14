using System;
using System.ComponentModel;

namespace AirConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        { 
            string selection;

         do{
                Console.WriteLine("\n********************************");
                Console.WriteLine("**   Welcome to AirConsole    **");
                Console.WriteLine("********************************");

                Console.WriteLine("\nTask Selection");
                Console.WriteLine("R: Reservation");
                Console.WriteLine("S: Seat Verification");
                Console.WriteLine("X: Exit the System");

                Console.Write("\nPlease enter the task you want to perform: ");

                selection = Console.ReadLine().ToUpper();


                if (selection == "R")
                {
                    
                    ReserveSeat.SelectSeat();
                    MainMenuReturn.ReturnToMainMenu();
                }

                if (selection == "S")
                {
                    
                    VerifySeat.VerifySelectedSeat();
                    MainMenuReturn.ReturnToMainMenu();
                }

                if (selection == "X")
                {
                   
                    Console.WriteLine("\nSession Complete. Goodbye!\n");
                    Environment.Exit(0);
                }
                if (selection != "R" && selection != "S" && selection != "X")
                {
                    Console.WriteLine("\nInvalid entry! Please try again.");
                    Console.WriteLine("-----------------------------------------------------");
                } 
            }while(selection != "R" && selection != "S" && selection != "X");
        }

       
    }
}

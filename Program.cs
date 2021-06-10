using System;

namespace AirConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("**   Welcome to AirConsole  **");
            Console.WriteLine("********************************");

            Console.WriteLine("\nTask Selection");
            Console.WriteLine("R: Reservation");
            Console.WriteLine("S: Seat Verification");
            Console.WriteLine("X: Exit the System");

            Console.Write("\nPlease enter the task you want to perform: ");

            string selection = Console.ReadLine().ToUpper();


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

            }

        }
    }
}

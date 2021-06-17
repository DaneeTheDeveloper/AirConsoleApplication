using System;
namespace AirConsoleApplication
{
    public class MainMenu
    {
        public static void Show()
        {
              string selection;

              ShowMenu();
                
            do{
                Console.Write("\nPlease enter the task you want to perform: ");

                selection = Console.ReadLine().ToUpper();


                if (selection == "R")
                {
                    
                    ReserveSeat.SelectSeat();
                    ShowMenu();
                    continue;
                }

                else if (selection == "S")
                {
                    
                    VerifySeat.VerifySelectedSeat();
                    ShowMenu();
                    continue;
                }

                else if (selection == "X")
                {
                   
                    Console.WriteLine("\nSession Complete. Goodbye!\n");
                    break;
                }
                else 
                {
                    Console.WriteLine("\nInvalid entry! Please try again.");
                } 
            }while(true);

        }
        public static void ShowMenu()
        {
                Console.WriteLine("\n********************************");
                Console.WriteLine("**   Welcome to AirConsole    **");
                Console.WriteLine("********************************");

                Console.WriteLine("\nTask Selection");
                Console.WriteLine("R: Reservation");
                Console.WriteLine("S: Seat Verification");
                Console.WriteLine("X: Exit the System");
            
        }
    }
}


using System;
using AirConsoleApplication.Reservations;

namespace AirConsoleApplication
{
    public class ReserveSeat
    {
        public static void SelectSeat()
        {
            Console.WriteLine("\n\n********************************");
            Console.WriteLine("**          Seat Class        **");
            Console.WriteLine("********************************");

            Console.WriteLine("\n\nSeat Class Selection:");
            Console.WriteLine("B: Business Class");
            Console.WriteLine("E: Economy Class");
            Console.WriteLine();

            string seatclassselection = Console.ReadLine().ToUpper();

            if (seatclassselection == "B")
            {
                BusinessClass.BusinessClassReservation();
            }
            if (seatclassselection == "E")
            {
                EconomyClass.EconomyClassReservation();
            } 
        }

        
    }
}

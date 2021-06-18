using System;
using System.Collections.Generic;
using ConsoleTables;
namespace AirConsoleApplication.Reservations
{
   public class BusinessClass:SeatingClass
   {
     public static void BusinessClassReservation()
        {
          
            {
            
            }

        }   
    }   
}
/*
1. How to build the Console Table and present the rows and columns
2. Prompt the user to enter the row number.
2a. Per Jake- you will need a *row validation*.
3. Prompt the user to enter the seat letter.
3a. You will also need a *column validation*.
4. The table needs to be in the base class, because all rows (Economy and Business) need to be validated
5. You will need a method that checks the empty spaces within the table.
5a. If it is empty, print that it is available. If it is not, print that it is not available.
6. If the space is available, prompt passenger details.
6a. Enter first name, last name, and passport.
7. Print message that confirms the seat was successfully booked.
*/
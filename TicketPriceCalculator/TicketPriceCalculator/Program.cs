using System;

namespace TicketPriceCalculator
{
    class TicketPriceCalculator
    {
        static void Main(string[] args)
        {
            int TicketPrice = 10;

            //customer
            Console.WriteLine("Input your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 65 || age <= 12)
            {
                TicketPrice = 7;
                Console.WriteLine("The price of your ticket is GHc" + TicketPrice);
            }

            else
            {
                TicketPrice = 10;
                Console.WriteLine("The price of your ticket is GHc" + TicketPrice);
            }
        }
    }
}

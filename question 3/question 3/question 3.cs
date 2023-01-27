using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    internal class question_3
    {
        public static void flight()
        {

            decimal[] flightFare = new decimal[5];
            Console.WriteLine("Enter the flight fare");
            for (int i = 0; i < flightFare.Length; i++)
            {
                flightFare[i] = Convert.ToDecimal(Console.ReadLine());
            }
            //foreach(decimal flight in flightFare)
            //{
            //    Console.WriteLine(flight);
            //}
            Console.WriteLine("Flight Fare is ");
            for (int i = 0; i < flightFare.Length; i++)
            {
                Console.WriteLine(flightFare[i]);
            }
            Console.WriteLine("_____________________________________________");
            decimal temp = 0;
            for (int i = 0; i < flightFare.Length; i++)
            {
                for (int j = i + 1; j < flightFare.Length; j++)
                {
                    if (flightFare[i] > flightFare[j])
                    {
                        temp = flightFare[i];
                        flightFare[i] = flightFare[j];
                        flightFare[j] = temp;

                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in flightFare)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Enter the value to be searched");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal index = 0;


            foreach (var items in flightFare)
            {
                if (a == items)
                {
                    index++;
                    int value = Array.IndexOf(flightFare, items);
                    Console.WriteLine("Element found " + items + " at index " + value);
                }
            }


        }
    }
}

// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

Console.WriteLine("Hello, World!");

Console.WriteLine("\nEnter the choice:");
int count = 0;
while (count == 0)
{

    Console.WriteLine("F: Enter your choice to print odd flight numbers");

    Console.WriteLine("W: Enter your choice to print even flight numbers");

    Console.WriteLine("Q: Enter your choice to print Prime flight numbers");

    Console.WriteLine("N: Enter your choice to print fibonacci flight numbers");

    Console.WriteLine("A: Enter your choice to print Amstrong flight numbers");

    Console.WriteLine("E: Enter E for EXIT");

    String input = Console.ReadLine();

    switch (input)
    {
        case "F":

            for (int i = 100; i < 120; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("F" + i);
                }
            }
            break;

    

        case "W": 

            for(int integer = 100; integer < 120; integer++)
            {
                if (integer % 2 == 0) 
                {
                    Console.WriteLine("F" + integer);
                }
            }
            break;

        case "Q":
            for(int i=100; i < 150; i++)
            {
                Boolean isPrime = true;

                if (i > 1)
                {
                    for(int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                }
                else
                {
                    isPrime= false;
                }
                if (isPrime)
                {
                    Console.WriteLine("Q" + i);
                }
            }
            break;

        case "N":
            int a = 0, b = 1, c;
            for (int i = 100; i<150; i++)
            {
                
                c = a + b;
                a = b;
                b=c;
                Console.WriteLine("N" + c);
            }
            break;

        case "A":
            for(int i = 100; i < 999; i++)
            {
                int temp = i;
                int reminder = 0;
                int result = 0;
                while (temp != 0)
                {
                    reminder = temp % 10;
                    result  += reminder * reminder * reminder;
                    temp = temp / 10;
                }
                if(result == i)
                {
                    Console.WriteLine("A" + result);
                }
            }
            break;

            case "E":
                count = 1;
            break;
 



        default:
            Console.WriteLine("Invalid");
            break;

     }

}
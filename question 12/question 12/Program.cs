// See https://aka.ms/new-console-template for more information
using System.Transactions;

Console.WriteLine("Hello, World!");



Console.WriteLine("\nEnter the size");
int size = Convert.ToInt32(Console.ReadLine());

string[] PassengerName = new string[size];
Console.WriteLine("\nEnter the Passengers name");
for (int i = 0;i < size; i++)
{
    PassengerName[i] = Console.ReadLine();
}


//foreach(string items in PassengerName)
//{
//    Console.WriteLine(items);
//}

Console.WriteLine("\n Enter the Destination");
string[] Destination = new string[size];

for (int i = 0; i < size; i++)
{
    Destination[i] = Console.ReadLine();
}

Console.WriteLine("\n");

string[] MergedArray = new string[size * 2];

int name = 0;

int place = 1;

foreach(string item in PassengerName)
{
    MergedArray[name] = item;
    name = name + 2;
}

foreach(string item in Destination)
{
    MergedArray[place] = item;
    place = place + 2;
}

Console.WriteLine("\n");

foreach(string item in MergedArray)
{
    Console.Write(",",item);
}
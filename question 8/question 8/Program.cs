// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("\nEnter the size");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nEnter the fare");
decimal [] fare = new decimal[size]; 

for (int i = 0;i < fare.Length; i++)
{
  fare[i] = (Convert.ToInt32(Console.ReadLine()));
}

Console.WriteLine("\nEnter the destination");

string[] destination = new string[size];
for(int i = 0;i < destination.Length;i++)
{
    destination[i] = Console.ReadLine();
}


Console.WriteLine("\nEnter the element to be searched");
int element = Convert.ToInt32(Console.ReadLine());

if( element < 5)
{
    Console.WriteLine("Flight fare: {0}", fare[element]);
    Console.WriteLine("Destiantion : {0}", destination[element]);

}
else 
{
    Console.WriteLine("\nValue not present");
}

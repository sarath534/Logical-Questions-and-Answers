using System.ComponentModel.DataAnnotations;

Console.WriteLine("Enter the flight fare");
decimal[] flightFare = new decimal[5];
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
    else
    {
        Console.WriteLine("Not found");
    }
}
decimal max = flightFare[0];
decimal min = flightFare[0];
for(int i = 0;i < flightFare.Length; i++)
{
    if(flightFare[i] > max)
    {
        max = flightFare[i];
    }
    if (flightFare[i]< min)
    {
        min = flightFare[i];    
    }
}
Console.WriteLine("The maximum fare is  " +max );
Console.WriteLine("The minimum fare is  " +min );
 int flag = 0;
decimal dupli = 0;
for(int i = 0; i < flightFare.Length; i++)
{
    for(int j = 0; j < flightFare.Length; j++)
    {
        if (flightFare[i] == flightFare[j])
        {
            flag ++;
            flightFare[j] = dupli;
        }
    }
}
if(flag >= 2)
{
    Console.WriteLine("Duplicate found " + dupli);
}
else
{
    Console.WriteLine("Not found");
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name = string.Empty;
Console.WriteLine("Enter the name");
name = Console.ReadLine();

Console.WriteLine(name);

Console.WriteLine("Enter total miles travelled");
 decimal miles = 0;
miles= decimal.Parse(Console.ReadLine());

Console.WriteLine(miles);

if (miles > 10000 && miles < 19999)
{
    Console.WriteLine("Award 10 frequent flyer points to " + name);
}
if (miles > 20000 && miles < 49999)
{
    Console.WriteLine("Award 20 frequent flyer points to " + name);
}
if (miles > 50000 && miles <99999 )
{
    Console.WriteLine("Award 30 frequent flyer points to " + name);
}
if (miles > 100000)
{
    Console.WriteLine("Award 50 frequent flyer points to " + name);
}

switch(miles)
{
    case  >= 10000 and <= 19999:
        Console.WriteLine("Award 10 frequent flyer points to " + name);
        break;
    case  >= 20000 and <= 49999:
        Console.WriteLine("Award 20 frequent flyer points to" + name);
        break;
    case >= 50000 and <= 99999:
        Console.WriteLine("Award 30 frequent flyer points to" + name);
        break;
    case >= 100000:
        Console.WriteLine("Award 50 frequent flyer points to" + name);
        break;
}

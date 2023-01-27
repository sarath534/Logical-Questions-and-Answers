// See https://aka.ms/new-console-template for more information
//using System;
//using System.Collections.Immutable;
//using System.Text;

int n = int.Parse(Console.ReadLine());
string[] names = new string[n];

Console.WriteLine("Enter the names");

for (int i = 0; i < n ; i++) {
  
    names[i] = Console.ReadLine();
}

foreach (string i in names)
{
    Console.WriteLine(i);
}
Console.WriteLine("________________________________________________________");

Console.WriteLine("Sort the array");
Array.Sort(names);
foreach(string i in names)
{
  Console.WriteLine(i);
}
Console.WriteLine("_________________________________________________________");
Array.Reverse(names);
foreach(string i in names)
{
    Console.WriteLine(i);
}
Console.WriteLine("__________________________________________________________");
Console.WriteLine("Search");
Console.WriteLine("Enter the name to search");
string? search = Console.ReadLine();
int count = 0;
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == search)
    {
        count++;
    }
   
}
    if (count != 0)
    {
        Console.WriteLine("Element found");
    }
    else
    {
        Console.WriteLine("Not found");
    }
Console.WriteLine("_____________________________________________________________");
    foreach(string name in names)
{
    Console.WriteLine(name+ ": " + name.Length);
}
Console.WriteLine("______________________________________________________________");
    foreach(string name in names)
{
    if (name != null)
    {
        var splits = name.Split(' ');
        Array.ForEach(splits, s => Console.WriteLine(s));
       }
}
Console.WriteLine("______________________________________________________________");
int index = 0;
string element = string.Empty;
for (int i = 0; i < names.Length; i++)
{
    for(int j = i; j < names.Length -1; j++)
    {
        if (names[i] == names[j+1])
        {
            index ++;
            element = names[i];
        }
           
    }
    
}
if (index != 0)
{
    Console.WriteLine("Duplicate found" + element);
}
else
{
    Console.WriteLine("Element not found");
}



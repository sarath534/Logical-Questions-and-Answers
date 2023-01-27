//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(@"
//0 - Even Positions
//1 - Odd Positions

//Enter your choice:");
//int position = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the size of array");

//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the element into array");
//decimal[] arr = new decimal[n*2];
//for (int i = position; i < n*2; i = i+2)
//{

//    arr[i] = Convert.ToDecimal(Console.ReadLine());
//}

//Console.WriteLine("Required Array:");

//foreach (decimal d in arr)
//{
//   Console.WriteLine(d);
//}

Console.WriteLine("Enter the flightfares:");
int fare = Convert.ToInt32(Console.ReadLine());
decimal[] arr = new decimal[fare *2]; 
int even = 0;
int odd = 1; 
Console.WriteLine("Enter the elements:");
for (int i = 0; i < fare; i++)
{
    decimal value = Convert.ToDecimal(Console.ReadLine());
    if (value % 2 == 0)
    {
        arr[even] = value;
        even += 2;
    }
    else
    {
        arr[odd] = value;
        odd += 2;
    }
}
foreach (decimal value in arr)
{
    Console.Write(value +" ");
}


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter the date of birth");
DateTime dob;
dob = DateTime.Parse(Console.ReadLine());

TimeSpan lifetime = DateTime.Now- dob;

double hours = lifetime.TotalHours;
Console.WriteLine("Your age in hours is " +Convert.ToInt32(hours));

double daily = lifetime.TotalDays;
Console.WriteLine("Your age in days is " + Convert.ToInt32(daily));
double weeks = daily / 7;
Console.WriteLine("Your age in weeks is " + Convert.ToInt32(weeks));

double months = daily / 12;
Console.WriteLine("Your age in months is " + Convert.ToInt32(months));

double years = daily / 365;
Console.WriteLine("Your age in year is " + Convert.ToInt32(years));

Console.WriteLine("Date  of birth leap year or not");

if(dob.Year % 4 == 0)
{
    Console.WriteLine("Dob is a leap year");
}
else
{
    Console.WriteLine("Dob is not a leap year");
}




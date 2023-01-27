// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("\n Enter the Date of birth");
DateTime[] dob = new DateTime[10];
int i;
for (i = 0; i < 3; i++)
{
    dob[i] = Convert.ToDateTime(Console.ReadLine());
}

for (i = 0; i < 3; i++)
{
    var today = DateTime.Now;

    var presentAge = today.Year - dob[i].Year;

    if (presentAge < 10)
    {
        Console.WriteLine("\n Kid");

    }
    if (presentAge > 10 && presentAge < 30)
    {
        Console.WriteLine("\n Youth");
    }

    if (presentAge > 30 && presentAge < 60)
    {
        Console.WriteLine("Adult");
    }
    else if (presentAge > 60)
    {
        Console.WriteLine("older");
    }
}

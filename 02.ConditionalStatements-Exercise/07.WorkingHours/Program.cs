
int hour = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

if (dayOfWeek == "Sunday")
{
    Console.WriteLine("closed");
}
else
{
    if (hour >= 10 && hour <= 18)
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
    }
}
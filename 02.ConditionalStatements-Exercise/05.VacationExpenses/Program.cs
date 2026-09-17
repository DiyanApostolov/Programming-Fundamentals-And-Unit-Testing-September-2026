
string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int countOfNigth = int.Parse(Console.ReadLine());

//"Spring", "Summer", "Autumn" and "Winter"
//"Hotel" and "Camping

double pricePerNigth = 0;

if (season == "Spring")
{
    if (accommodationType == "Hotel")
    {
        pricePerNigth = 30 * 0.8; // -20%
    }
    else if (accommodationType == "Camping")
    {
        pricePerNigth = 10 * 0.8; // -20%
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        pricePerNigth = 50; // 0%
    }
    else if (accommodationType == "Camping")
    {
        pricePerNigth = 30; // 0%
    }
}
else if (season == "Autumn")
{
    if (accommodationType == "Hotel")
    {
        pricePerNigth = 20 * 0.7; // -30%
    }
    else if (accommodationType == "Camping")
    {
        pricePerNigth = 15 * 0.7; // -30%
    }
}
else if (season == "Winter")
{
    if (accommodationType == "Hotel")
    {
        pricePerNigth = 40 * 0.9; // -10%
    }
    else if (accommodationType == "Camping")
    {
        pricePerNigth = 10 * 0.9; // -10%
    }
}

double finalPrice = countOfNigth * pricePerNigth;

Console.WriteLine($"{finalPrice:F2}");


int degrees = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();

string clothing = "";
string shoes = "";

//"Morning", "Afternoon", "Evening"
if (timeOfDay == "Morning")
{
    switch (degrees)
    {
        case >= 10 and <= 18:
            clothing = "Sweatshirt";
            shoes = "Sneakers";
            break;
        case > 18 and <= 24:
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
        case >= 25:
            clothing = "T-Shirt";
            shoes = "Sandals";
            break;
    }
}
else if (timeOfDay == "Afternoon")
{
    switch (degrees)
    {
        case >= 10 and <= 18:
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
        case > 18 and <= 24:
            clothing = "T-Shirt";
            shoes = "Sandals";
            break;
        case >= 25:
            clothing = "Swim Suit";
            shoes = "Barefoot";
            break;
    }
}
else if (timeOfDay == "Evening")
{
    clothing = "Shirt";
    shoes = "Moccasins";
}

Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");
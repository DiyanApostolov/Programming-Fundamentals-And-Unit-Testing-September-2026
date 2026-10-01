
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

CalculateOrder(product, quantity);

static void CalculateOrder(string product, int quantity)
{
    //	coffee – 1.50
    //	water – 1.00
    //	coke – 1.40
    //	snacks – 2.00

    double finalPrice = 0;

    if (product == "coffee")
        finalPrice = quantity * 1.50;
    else if (product == "water")
        finalPrice = quantity * 1;
    else if (product == "coke")
        finalPrice = quantity * 1.40;
    else if (product == "snacks")
        finalPrice = quantity * 2;

    Console.WriteLine($"{finalPrice:F2}");
}

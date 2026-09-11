
int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int quantityOfThinner = int.Parse(Console.ReadLine());
int hoursForCraftsmen = int.Parse(Console.ReadLine());

double priceForNylon = 1.50;
double priceForPaint = 14.50;
double priceForThinner = 5;
double bagsPrice = 0.40;

double nylonPrice = (amountOfNylon + 2) * priceForNylon;
double paintPrice = amountOfPaint * 1.1 * priceForPaint; // * 1.1 = + 10%
double thinnerPrice = quantityOfThinner * priceForThinner;

double priceForAllMaterials = nylonPrice + paintPrice + thinnerPrice + bagsPrice;

double oneHourForCraftsmen = priceForAllMaterials * 0.3;
double craftsmenWork = hoursForCraftsmen * oneHourForCraftsmen;

double finalPrice = priceForAllMaterials + craftsmenWork;

Console.WriteLine(finalPrice);



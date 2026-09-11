// Input
int numberOfChickenMenus = int.Parse(Console.ReadLine());
int numberOfFishMenus = int.Parse(Console.ReadLine());
int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

// Prices
double priceForChickenMenu = 10.35;
double priceForFishMenu = 12.40;
double priceForVegetarianMenu = 8.15;
double priceForDelivery = 2.50;

// Calculations 
double priceForAllChickenMenus = numberOfChickenMenus * priceForChickenMenu;
double priceForAllFishMenus = numberOfFishMenus * priceForFishMenu;
double priceForAllVegetarianMenus = numberOfVegetarianMenus * priceForVegetarianMenu;

double currentBill = priceForAllChickenMenus + priceForAllFishMenus + priceForAllVegetarianMenus;

double dessert = currentBill * 0.2;

double finalPrice = currentBill + dessert + priceForDelivery;

// Output
Console.WriteLine(finalPrice);


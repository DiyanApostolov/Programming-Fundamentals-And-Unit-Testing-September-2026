
int yearFee = int.Parse(Console.ReadLine());

double sneakersPrice = yearFee * 0.6; // - 40%
double uniformPrice = sneakersPrice * 0.8; // - 20%
double ballPrice = uniformPrice / 4; // * 0.25
double accessoriesPrice = ballPrice / 5; // * 0.2

double finalPrice = yearFee + sneakersPrice + uniformPrice + ballPrice + accessoriesPrice;

Console.WriteLine(finalPrice);
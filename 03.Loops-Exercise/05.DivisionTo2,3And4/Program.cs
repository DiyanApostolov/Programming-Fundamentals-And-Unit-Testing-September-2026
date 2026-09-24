
int n = int.Parse(Console.ReadLine());

int divideBy2Counter = 0;
int divideBy3Counter = 0;
int divideBy4Counter = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
        divideBy2Counter++;

    if (currentNumber % 3 == 0)
        divideBy3Counter++;

    if (currentNumber % 4 == 0)
        divideBy4Counter++;  
}

double divideBy2Percent = (double)divideBy2Counter / n * 100;
double divideBy3Percent = (double)divideBy3Counter / n * 100; ;
double divideBy4Percent = (double)divideBy4Counter / n * 100;

Console.WriteLine($"{divideBy2Percent:F2}%");
Console.WriteLine($"{divideBy3Percent:F2}%");
Console.WriteLine($"{divideBy4Percent:F2}%");
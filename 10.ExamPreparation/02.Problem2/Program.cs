
int[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

int threshold = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;
int minNumber = int.MaxValue;

for (int i = 0; i < threshold; i++)
{
    int currentNumber = numbers[i];

    if (currentNumber > maxNumber)
        maxNumber = currentNumber;

    if (currentNumber < minNumber)
        minNumber = currentNumber;
}

Console.WriteLine(maxNumber);
Console.WriteLine(minNumber);

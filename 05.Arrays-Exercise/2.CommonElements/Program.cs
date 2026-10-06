
int[] firstArray = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();

int[] secondArray = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();

foreach (int currentNumber in firstArray)
{
    if (secondArray.Contains(currentNumber))
    {
        Console.Write(currentNumber + " ");
    }
}


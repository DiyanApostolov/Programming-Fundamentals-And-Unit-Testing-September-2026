
int[] numbers = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();

string result = "";

for (int i = 0; i < numbers.Length; i++)
{
    bool isTopInteger = true;
    int currentElement = numbers[i];

    for (int j = i + 1; j < numbers.Length; j++)
    {
        int nextRightElement = numbers[j];

        if (currentElement <= nextRightElement)
        {
            isTopInteger = false;
            break;
        }
    }

    if (isTopInteger)
    {
        result += currentElement + " ";
    }
}

Console.WriteLine(result);


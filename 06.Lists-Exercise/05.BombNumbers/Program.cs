
List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

string[] input = Console.ReadLine().Split(' ');
int bomb = int.Parse(input[0]);
int power = int.Parse(input[1]);

while (numbers.Contains(bomb))
{
    int bombIndex = numbers.IndexOf(bomb);

    int startIndex = bombIndex - power;
    int endIndex = bombIndex + power;

    if (startIndex < 0)
        startIndex = 0;

    if (endIndex >= numbers.Count)
        endIndex = numbers.Count - 1;

    for (int i = 1; i <= power * + 1; i++)
    {
        numbers.RemoveAt(startIndex);
    }
}

Console.WriteLine(numbers.Sum());

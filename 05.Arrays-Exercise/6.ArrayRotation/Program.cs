
int[] numbers = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstNumber = numbers[0]; // take first element

    for (int j = 1; j < numbers.Length; j++)
    {
        numbers[j - 1] = numbers[j]; // move every element one index to the left
    }

    numbers[numbers.Length - 1] = firstNumber; // move first element to the end
}

Console.WriteLine(string.Join(" ", numbers));
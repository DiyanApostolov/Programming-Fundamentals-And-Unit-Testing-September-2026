
int[] numbers = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();

while (numbers.Length > 1)
{
    int[] condensedArray = new int[numbers.Length - 1];

    for (int i = 0; i < numbers.Length - 1; i++) // miss last element
    {
        int sum = numbers[i] + numbers[i + 1]; // summing adjacent couples of elements 

        condensedArray[i] = sum; // add new element to condensedArray
    }

    numbers = condensedArray; // replace numbers array with condensedArray
}

Console.WriteLine(numbers[0]);



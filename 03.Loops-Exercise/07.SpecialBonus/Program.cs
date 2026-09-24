
int stopNumber = int.Parse(Console.ReadLine());

int lastNumber = 0;

int currentNumber = int.Parse(Console.ReadLine());

while (currentNumber != stopNumber)
{
    lastNumber = currentNumber;
    currentNumber = int.Parse(Console.ReadLine());
}

Console.WriteLine(lastNumber * 1.2);


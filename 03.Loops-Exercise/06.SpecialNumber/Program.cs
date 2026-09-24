
int number = int.Parse(Console.ReadLine());

int temp = number;
bool isSpecial = true;

while (temp > 0)
{
    int lastDigit = temp % 10; // take last digit

    if (number % lastDigit != 0)
    {
        isSpecial = false;
        break;
    }

    temp /= 10; // remove last digit
}

if (isSpecial)
{
    Console.WriteLine($"{number} is special");
} 
else
{
    Console.WriteLine($"{number} is not special");
}
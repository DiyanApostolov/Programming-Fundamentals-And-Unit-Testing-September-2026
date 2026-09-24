// solution for problem 6 with for loop

string number = Console.ReadLine();

bool isSpecial = true;

for (int i = 0; i < number.Length; i++)
{
    int currentDigit = int.Parse(number[i].ToString());

    if (int.Parse(number) % currentDigit != 0)
    {
        isSpecial = false;
        break;
    }
}

if (isSpecial)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}
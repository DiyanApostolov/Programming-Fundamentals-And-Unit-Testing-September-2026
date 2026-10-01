
int number = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine(GetMultipleOfEvenAndOdds(number));


static int GetSumOfEvenDigits(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int lastDigit = number % 10; // take last gidit

        if (lastDigit % 2 == 0) // check is even
        {
            sum += lastDigit;
        }

        number /= 10; // remove last gidit
    }

    return sum;
}

static int GetSumOfOddDigits(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int lastDigit = number % 10; // take last gidit

        if (lastDigit % 2 != 0) // check is odd
        {
            sum += lastDigit;
        }

        number /= 10; // remove last gidit
    }

    return sum;
}

static int GetMultipleOfEvenAndOdds(int number)
{
    return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
}
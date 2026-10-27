
int n = int.Parse(Console.ReadLine());

string output = "";

for (int i = 2; i <= n; i++)
{
    int temp = i;
    bool isMagicNumber = true;
    int sumDigits = 0;

    //123
    while(temp > 0)
    {
        int lastDigit = temp % 10;

        if (IsPrime(lastDigit))
        {
            sumDigits += lastDigit;
        }
        else
        {
            isMagicNumber = false;
            break;
        }

        temp /= 10; // remove last gidit
    }

    if (sumDigits % 2 != 0) 
    {
        isMagicNumber = false;
    }

    if (isMagicNumber)
    {
        output += i + " ";
    }
}

if (output == "")
{
    Console.WriteLine("no");
}
else
{
    Console.WriteLine(output);
}


bool IsPrime(int num)
{
    if (num < 2)
        return false;

    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }

    return true;
}

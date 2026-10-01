
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine(GetProductSign(num1, num2, num3));



static string FindMultiplicationSign(int num1, int num2, int num3)
{
    string result = "";

    if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        result = "zero";
    }
    else if (num1 > 0 && num2 > 0 && num3 > 0) // + + +
    {
        result = "positive";
    }
    else if (num1 > 0 && num2 < 0 && num3 < 0) // + - -
    {
        result = "positive";
    }
    else if (num1 < 0 && num2 < 0 && num3 > 0) // - - +
    {
        result = "positive";
    }
    else if (num1 < 0 && num2 > 0 && num3 < 0) // - + -
    {
        result = "positive";
    }
    else
    {
        result = "negative";
    }

    return result;
}

// ChatGPT - method
static string GetProductSign(int a, int b, int c)
{
    if (a == 0 || b == 0 || c == 0)
    {
        return "zero";
    }

    int negativeCount = 0;

    if (a < 0)
    {
        negativeCount++;
    }

    if (b < 0)
    {
        negativeCount++;
    }

    if (c < 0)
    {
        negativeCount++;
    }

    if (negativeCount % 2 == 0)
    {
        return "positive";
    }

    return "negative";
}
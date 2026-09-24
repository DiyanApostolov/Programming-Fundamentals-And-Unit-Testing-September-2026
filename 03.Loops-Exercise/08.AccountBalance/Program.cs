
string input = Console.ReadLine();

double accountBalance = 0;

while (input != "End")
{
    double currentMoney = double.Parse(input);

    if (currentMoney > 0)
    {
        accountBalance += currentMoney;
        Console.WriteLine($"Increase: {currentMoney:F2}");
    }
    else
    {
        accountBalance -= Math.Abs(currentMoney);
        Console.WriteLine($"Decrease: {Math.Abs(currentMoney):F2}");
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {accountBalance:F2}");
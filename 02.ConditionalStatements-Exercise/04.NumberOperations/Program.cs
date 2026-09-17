
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();
double result = 0;

switch (operation)
{
    case "+": 
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    case "*":
        result = firstNumber * secondNumber;
        break;
    case "/":
        result = firstNumber / secondNumber;
        break;
}

Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:F2}");

string product = Console.ReadLine();

switch (product)
{
    case "banana" or "apple" or "kiwi" or "cherry" or "lemon":
        Console.WriteLine("fruit");
        break;
    case "cucumber" or "pepper" or "carrot":
        Console.WriteLine("vegetable");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}

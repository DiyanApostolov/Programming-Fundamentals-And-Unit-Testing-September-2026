
int n = int.Parse(Console.ReadLine());

List<string> guestList = new List<string>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    string name = input[0];

    if (input[2] == "not")
    {
        if (guestList.Contains(name))
        {
            guestList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
    else
    {
        if (guestList.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guestList.Add(name);
        }
    }
}

foreach (var name in guestList)
{
    Console.WriteLine(name);
}
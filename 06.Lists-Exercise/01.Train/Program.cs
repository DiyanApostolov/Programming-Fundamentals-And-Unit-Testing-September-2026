
List<int> train = Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToList();

int maxCapacity = int.Parse(Console.ReadLine());

while (true)
{
    string input = Console.ReadLine();

    if (input == "end")
        break;

    string[] cmdArg = input.Split(' ');

    if (cmdArg[0] == "Add")
    {
        int passangers = int.Parse(cmdArg[1]);
        train.Add(passangers);
    }
    else
    {
        int passangers = int.Parse(cmdArg[0]);

        for (int i = 0; i < train.Count; i++)
        {
            if (train[i] + passangers <= maxCapacity)
            {
                train[i] += passangers;
                break;
            }
        }
    }
}

Console.WriteLine(string.Join(' ', train));
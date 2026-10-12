
List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

string[] cmdArg = Console.ReadLine().Split(' ');

while (cmdArg[0] != "end")
{
    string command = cmdArg[0];

    switch (command)
    {
        case "Add":
            numbers.Add(int.Parse(cmdArg[1]));
            break;
        case "Remove":
            numbers.Remove(int.Parse(cmdArg[1]));
            break;
        case "RemoveAt":
            numbers.RemoveAt(int.Parse(cmdArg[1]));
            break;
        case "Insert":
            int number = int.Parse(cmdArg[1]);
            int index = int.Parse(cmdArg[2]);
            numbers.Insert(index, number);
            break;
    }

    cmdArg = Console.ReadLine().Split(' ');
}

Console.WriteLine(string.Join(' ', numbers));



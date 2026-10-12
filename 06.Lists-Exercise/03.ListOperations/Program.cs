
List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

while (true)
{
    string[] cmdArg = Console.ReadLine().Split(' ');
    string command = cmdArg[0];

    if (command == "Add")
    {   
        int number = int.Parse(cmdArg[1]);
        numbers.Add(number);
    }
    else if (command == "Insert")
    {
        int number = int.Parse(cmdArg[1]);
        int index = int.Parse(cmdArg[2]);

        if (index >= 0 && index < numbers.Count) // check index is valid
            numbers.Insert(index, number);
        else
            Console.WriteLine("Invalid index");

    }
    else if (command == "Remove")
    {
        int index = int.Parse(cmdArg[1]);

        if (index >= 0 && index < numbers.Count) // check index is valid
            numbers.RemoveAt(index);
        else
            Console.WriteLine("Invalid index");
    }
    else if (command == "Shift")
    {
        int count = int.Parse(cmdArg[2]);

        if (cmdArg[1] == "left")
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]); // add first element in the end
                numbers.RemoveAt(0);     // remove first elemennt
            }
        }
        else if (cmdArg[1] == "right")
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]); // add last element in the start
                numbers.RemoveAt(numbers.Count - 1); // remove last element
            }
        }
    }
    else if (command == "End")
    {
        break;
    }
}

Console.WriteLine(string.Join(' ', numbers));

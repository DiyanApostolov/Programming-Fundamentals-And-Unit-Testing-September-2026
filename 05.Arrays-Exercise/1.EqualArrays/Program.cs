
string[] firstArray = Console.ReadLine().Split(" ");
string[] secondArray = Console.ReadLine().Split(" ");

bool isIdentical = true;

for (int i = 0; i < firstArray.Length; i++)
{
    string firstArrayElement = firstArray[i];
    string secondArrayElement = secondArray[i];

    if (firstArrayElement != secondArrayElement)
    {
        isIdentical = false;
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}
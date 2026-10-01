
string input = Console.ReadLine();

int vowelsCount =  FindVowelsCount(input);

Console.WriteLine(vowelsCount);


static int FindVowelsCount(string text)
{
    int vowelsCounter = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char currentSymbol = text[i];

        switch (currentSymbol)
        {
            case 'a': 
            case 'A': 
            case 'o': 
            case 'O': 
            case 'u': 
            case 'U': 
            case 'e': 
            case 'E': 
            case 'i': 
            case 'I': 
                vowelsCounter++;
                break;
        }
    }

    return vowelsCounter;
}

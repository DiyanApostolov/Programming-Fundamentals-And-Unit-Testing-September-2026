
string password = Console.ReadLine();

if (!ChechPasswordContain6To10Characters(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!CheckPasswordContainsOnlyLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!CheckPasswordContainsAtLeastTwoDigits(password))
{
    Console.WriteLine("Password must have at least 2 digits");
}

if (ChechPasswordContain6To10Characters(password) &&
    CheckPasswordContainsOnlyLettersAndDigits(password) &&
    CheckPasswordContainsAtLeastTwoDigits(password))
{
    Console.WriteLine("Password is valid");
}


//•	It should contain 6 – 10 characters (inclusive)
static bool ChechPasswordContain6To10Characters(string password)
{
    if (password.Length >= 6 && password.Length <= 10)
    {
        return true;
    }

    return false;
}

//•	It should contain only letters and digits
static bool CheckPasswordContainsOnlyLettersAndDigits(string password)
{
    for (int i = 0; i < password.Length; i++)
    {
        char symbol = password[i];

        if (!char.IsLetterOrDigit(symbol))
        {
            return false;
        }
    }

    return true;
}

//• It should contain at least 2 digits 
static bool CheckPasswordContainsAtLeastTwoDigits(string password)
{
    int counter = 0;

    for (int i = 0; i < password.Length; i++)
    {
        char symbol = password[i];

        if (char.IsDigit(symbol))
        {
            counter++;
        }
    }

    if (counter >= 2)
    {
        return true;
    }

    return false;
}

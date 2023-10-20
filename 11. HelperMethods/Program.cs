Console.WriteLine("The Name Game");

Console.WriteLine("What's your first name");
string firstName = Console.ReadLine();

Console.WriteLine("What's your last name");
string lastName = Console.ReadLine();

Console.WriteLine("What city where you born?");
string city = Console.ReadLine();





// Metode DisplayResults kaldes, med de 3 variabler der returneres fra ReverseString metoden
DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

DisplayResult(ReverseString(firstName + " " + lastName + " " + city));



// method der konvertere string til string array, og ombytter rækkefølgen
static string ReverseString(string message)
{
    char[] messageArray = message.ToCharArray();
    Array.Reverse(messageArray);

    return String.Concat(messageArray);
}

// metode der printer alle 3 strings
static void DisplayResult(string reversedfirstname, string reversedlastname, string reversedcity)
{
    Console.WriteLine("Results:");

    Console.Write($"{reversedfirstname} " +
        $"{reversedlastname} " +
        $"{reversedcity}");
}

// Overloaded method - der printer en valgfri string
static void DisplayResult(string message)
{
    Console.WriteLine("Result:");

    Console.Write($"{message}");
}



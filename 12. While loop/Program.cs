/* 
  
 While loop bruges når man på forhånd ikke ved hvor mange gang man skal itere

*/


// Eksempel: While loop der køre bruger menu uendeligt

bool displayMenu = true;

while (displayMenu)
{
   displayMenu = MainMenu();
}

static bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Chose an option");
    Console.WriteLine("1) Print numbers");
    Console.WriteLine("2) Guessing Game");
    Console.WriteLine("3) Exit");
    string result = Console.ReadLine();

    if(result == "1")
    {
        PrintNumbers();
        return true;
    } else if (result == "2")
    {
        GuessingGame();
        return true;
    } else if (result == "3")
    {       
        return false;
    } else
    {
        Console.WriteLine("Invalid option");
        return true;
    }
}

static void PrintNumbers() 
{
    Console.Clear();
    Console.WriteLine("Print numbers");
    Console.WriteLine("Type a number");
    int result = int.Parse(Console.ReadLine());
    int counter = 1;
    while (counter < result + 1) 
    {
        Console.WriteLine(counter);
        Console.WriteLine("-");
        counter++;
    }
}

static void GuessingGame()
{
    Console.Clear();
    Console.WriteLine("Guessing game");

    Random myRandom = new Random();                         // Random class istancieres
    int randomNumber = myRandom.Next(1, 11); // Random number oprettes ml. 1 og 10
    
    int guess = 0;  // Hvor mange guesses bruger har brugt
    bool incorrect = true;

    do
    {
        Console.WriteLine("Guess a number between 1 - 10");
        string result = Console.ReadLine();
        guess++;        // Når der gættes korrekt opbevares det i variabel

        if (result == randomNumber.ToString())
        {
            Console.WriteLine("You guessed correct");
            incorrect = false;
        }
        else
        {
            Console.WriteLine("Wrong, try again");
            
        }
    }
    while (incorrect);
    {
        Console.WriteLine("corect it took" + guess + "guesses");
    }
    
}
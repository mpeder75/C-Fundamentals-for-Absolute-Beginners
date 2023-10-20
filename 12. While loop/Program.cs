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
    Console.WriteLine("Chose an option");
    Console.WriteLine("1) Option 1");
    Console.WriteLine("2) Option 2");
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
    Console.WriteLine("Print numbers");
    Console.WriteLine("Type a number");
    int result = int.Parse(Console.ReadLine());
    int counter = 1;
    while (counter < result +1) 
    {
        Console.WriteLine(counter);
        Console.WriteLine("-");
        counter++;
    }
}

static void GuessingGame()
{
    Console.WriteLine("Guessing game");
}
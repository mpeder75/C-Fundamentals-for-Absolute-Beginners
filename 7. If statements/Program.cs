
/*
// Input fra brugerr
Console.WriteLine("Please type something");
string userInput = Console.ReadLine();

Console.WriteLine($"You entered: {userInput}");*/



Console.WriteLine("Would you prefer door number: 1, 2, or 3? ");
string userValue = Console.ReadLine();

if (userValue == "1")
{
    Console.WriteLine($"You won a new car ");
} else if (userValue == "2")
{
    Console.WriteLine($"There is nothing behind the door");
} else if (userValue == "3")
{
    Console.WriteLine($"You won a free meal");
} else
{
    Console.WriteLine("Invalid input");
}
*/


Console.WriteLine("Choose door: 1, 2 or 3!");
string userInput = Console.ReadLine();
/*
string msg = "";

if(userValue == "1")
{
    msg = "You won a boat!";
} else if (userValue == "2")
{
    msg = "The door is empty";
} else if (userValue == "3")
{
    msg = "You won a cat";
} else
{
    msg = "Invalid input";
}

Console.WriteLine(msg);
*/

// ------------ Conditional operator ---------- //

// Hvis userValue er 1 sættes message til 'boat'
// ellers sættes message til 'Halloo'
string message = (userInput == "1") ? "boat" : "Halloo";
Console.WriteLine("You won a {0}", message);
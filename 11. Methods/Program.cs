
/* Methods - betegnes også som et underprogram, eller en funktion */


// Method der printer
Print("Michael");

void Print(string name)
{
    Console.WriteLine(name);
}



// Method der returnere to strings
Console.WriteLine(AddTwoStrings("Hello", "world"));

string AddTwoStrings(string a, string b)
{
    return $"{a} {b}";
}



// Method der tager imod brugerinput, og printer det ud gennem en method
Console.WriteLine("Enter first name: ");
string myFirstName = Console.ReadLine();
Console.WriteLine("Enter last name: ");
string myLastName = Console.ReadLine();

Console.WriteLine(PrintMyName(myFirstName, myLastName));

string PrintMyName(string firstname, string lastname)
{
    return $"Hello {firstname} {lastname}";
}




// Expression body methods

Gange(5.0, 6.0);

static double Gange(double a, double b) => a * b;




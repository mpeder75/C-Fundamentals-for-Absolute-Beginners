
// Variabel oprettes og reservere et område i memory
// Variabler skal ses som en container for noget data

/* 
    Man kan opbevare:
    • int  - tal
    • string  - tekst
    • DateTime - date objekter 
*/

// Man declare datatype på variabel også navn på variabel 
int x = 7;
int y = x + 3;

Console.WriteLine(y);



/* ----------- Strings ----------- */

string myFirtstName = "Michael";
Console.WriteLine(myFirtstName);


/* var datatype:
   compiler finder selv ud af hvilken datatype 'myFirstName' er
   var kræver at når der declares skal der assignes en værdi */
var myFirstName = "Michael";



/* ----------- Konvertere en datatype til en anden ----------- */


// konverter en int til en string med ToString()
int a = 7;
string b = "bob";

string myFirstTry = a.ToString() + b;

Console.WriteLine(myFirstTry);



// konverter strig til int med int.Parse

int d = 7;
string e = "5";

int mySecondTry = d + int.Parse(e);

Console.WriteLine(mySecondTry);

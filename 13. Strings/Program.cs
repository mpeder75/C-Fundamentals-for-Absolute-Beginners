/*

String er et array af chars

*/


// ------------ Format strings ------------ //

// 1. insæt "" indeni en string
using System.Text;

string myExample1 = "My \"so-called\" life";

// 2. indsæt en ny linje
string myExample2 = "What if I need a\n new line";

// 3. bruge backslash - ex. i en fil sti
string myExample3a = "Go to your c:\\drive";

// eller opsætte at \ skal bruges som regulær \
string myExample3b = @"Go to your c:\drive";

// 4. Formatere en string
string myExample4 = String.Format("{0} = {1}", "First", "Second");

// 5. Formater så der udskriver 123.45 kr.
string myExample5 = String.Format("{0:C}", 123.45);

// 6. Formater et tal så det har punktun og komma
string myExample6 = string.Format("{0:N}", 1234567890);

// 7. Formater så det udskrives som procent
string myExample7 = string.Format("Percentage: {0:P}", .123);

// 8. Formater telefonnummer med landekode
string myExample8 = string.Format("Phone Number: {0:(##) ########}", 4560379107);


// ------------ Manipulate strings ------------ //


string myString = " That summer we took threes across the board ";

// Print ud fra en string fra et index i selve string - her fra pos 6
string myString1 = myString.Substring(6);

// Printe et interval ud fra en længer string - Her fra pos 6 til pos 10
string myString2 = myString.Substring(6, 14);

// Konverter string til uppercase
string myString4 = myString.ToUpper();

// Erstat bogstaver med et andet bogstav - Her erstattes mellemrum med --
string myString5 = myString.Replace(" ", "--");

// Slette et specifikt interval indefra en string
string myString6 = myString.Remove(6, 14);


// Slette mellemrum foran string og bagved string
string myString7 = String.Format("Length before: {0} -- Length after: {1}",
    myString.Length, 
    myString.Trim().Length);


// StringBuilder class - Tælle til 100 OG påsætte "--" ved hver iteration
StringBuilder newString = new StringBuilder();

for (int i = 0; i < 100; i++)
{
    newString.Append("--");
    newString.Append(i);
}






Console.WriteLine(newString);

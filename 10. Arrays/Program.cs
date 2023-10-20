
/* Array: En samling af data der har en fastlaft længde */


// Declare et array med 5 pladser
using System.Runtime.InteropServices;

int[] myFirstArray = new int[5];

myFirstArray[0] = 1;
myFirstArray[1] = 2;
myFirstArray[2] = 3;
myFirstArray[3] = 4;
myFirstArray[4] = 5;


// Declare et array og assign værdier direkte
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


// Printe et array index ud
Console.WriteLine($"Her printes index 0 ud, som har værdi: {myFirstArray[0].ToString()}");


// Printe hele array ud
for (int i = 0; i < myFirstArray.Length; i++)
{
    Console.WriteLine($"Index {i} har værdien {myFirstArray[i]}");
}


// Total længde på array
Console.WriteLine($"Tatal længde på array er: {myFirstArray.Length}");


// Print det mindst og største nummer ud i array
int smallestNumber = numbers[0];
int largestNumber = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
     if (numbers[i] < smallestNumber)
    {
        smallestNumber = numbers[i];
    } 
    
    if (numbers[i] > largestNumber)
    {
        largestNumber = numbers[i];
    }
}

Console.WriteLine($"The smallest number is: {smallestNumber}\nThe largest is: {largestNumber}");


// String array
string[] names = new string[] { "Bob", "John", "Tim", "Poul", "Harry"};

foreach(string name in names)
{
    Console.WriteLine(name);
}


// Bytte rundt på string, og printe ud bogstav for bogstav baglæns
string zig = "life was like a box of chocolates. You never know what you're gonna get";

char[] charArray = zig.ToCharArray();    // 1. String zig konverteres til char[] array

Array.Reverse(charArray);               // 2. Nu bruges Array.Reverse(charArray) så array byttes rundt 

foreach(char zigChar in charArray)      // 3. Nu loopes igennem charArray
{
    Console.WriteLine(zigChar);
}

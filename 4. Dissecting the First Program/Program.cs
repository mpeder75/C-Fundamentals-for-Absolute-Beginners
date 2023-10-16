
// Class library = Et library lavet af Microsoft med metoder der kan bruges
// ex. Math class


// Runtime = CLR, sørger for low level details så programmør ikke selv skal
// sørger desuden også for at få tømt ram etc. automatisk


// Her bruges class System.Consol class med metoden WriteLine til at printe Hello World
Console.WriteLine("Hello world");
Console.ReadLine();


// når . bruges betegnes det "member access" som giver class member methods

/* Curly braces - Dette betegnes for en Code block

    {
        Kode...
    }

*/


/*
 
Når "Hello world" bruges "" til at informere man passer en literal string ind i metoden
  
Tænk altidat når der er  ()  er det en metode man bruger

*/ 



/*
 
 For at lave en release version, der ikke har bin/debug

    ( som blot er debuggerens informationer)
 
Skal man:

    1. Til venstre for "Any cpu" dropdown er der en "Debug" dropdown
    2. Ændre denne til "Realease"
    3. I Build -> Vælg Builld solution (ctrl+shift+B)
    4. Release version findes nu i bin/release mappen

 
*/
/*

 En Class er et blueprint/template for at oprette objekter

 En class bruges til at oprette properties og methods der er relavente for ex. et Car objekt

 1. Man definere sin class med instansvariabler, methods...
 2. Derefter instancieres en instans af class i Program.cs 

 Laves en instans af en Class, kan det også betgnes som et objekt 
  
*/


Car myCar = new Car();      

myCar.Make = "Honda";       
myCar.Model = "Civic";
myCar.Year = 2001;
myCar.Color = "Black";

Console.WriteLine($"Make: {myCar.Make}\nModel: {myCar.Model}\nYear: {myCar.Year}\nColor: {myCar.Color}");



// Method kaldes med argument og gemmes i myCarValue
decimal myCarValue = myCar.DetermineMarketValue();
Console.WriteLine("Marke value: {0:C}", myCarValue);



class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }


    // Method der beregner marketValue - Man behøver ikke passe car objekt ind
    public decimal DetermineMarketValue()
    {
        decimal carValue;

        if(Year > 1999)
        {
            carValue = 10000;
        } else
        {
            carValue = 7000;
        }
        return carValue;
    }
}


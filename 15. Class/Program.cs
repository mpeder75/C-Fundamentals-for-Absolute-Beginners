/*

 En Class er et blueprint/template for at oprette objekter

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


decimal myCarValue = DetermineMarketValue(myCar);
Console.WriteLine("{0:C}", myCarValue);


static decimal DetermineMarketValue(Car car)
{
    decimal carValue = 100.0m;
    return carValue;
}




class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}
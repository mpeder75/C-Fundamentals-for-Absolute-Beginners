/*

 En Class er et blueprint/template for at oprette objekter

 En class bruges til at oprette properties og methods der er relavente for ex. et Car objekt

 1. Man definere sin class med instansvariabler, methods...
 2. Derefter instancieres en instans af class i Program.cs 

 Laves en instans af en Class, kan det også betgnes som et objekt 
  
*/


Car myCar = new Car();
myCar.Make = "Audi";
myCar.Model = "A4";
myCar.Year = 2000;
myCar.Color = "Dark blue";


// 1. Lave en EKSTRA reference til samme objekt (kræver myCar er istancieret)
Car myOtherCar;
myOtherCar = myCar;
Console.WriteLine($"Make: {myOtherCar.Make}\nModel: {myOtherCar.Model}\nYear: {myOtherCar.Year}\nColor: {myOtherCar.Color}");

// 2. Nu kan man med referencen myOtherCar sette properties på myCar objektet
myOtherCar.Model = "A6";
Console.WriteLine($"\nModel have been changed to: {myOtherCar.Model}\n");

// 3. Er myCar så ændret med den nye Model? JA
Console.WriteLine($"Er myCar også ændret til A6? -> Ja: {myCar.Model}");

// 4. Hvis man vil "slette" referencen myOtherCar
myOtherCar = null;




class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

}


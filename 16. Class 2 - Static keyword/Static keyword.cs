/*

Static keyword: Console er en statisk class

Dvs. man behøve ikke at istanciere Console class, dents methods er tilgændelige i din instans eller class

Static method: metoden er tilgændelig indefra objektet
   
*/


Car myCar = new Car("Audi", "A6", 2019, "dark blue");

Car.MyMethod();



class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Car(string make, string model, int year, string color)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Color = color;
    }

    // static method - Static methods kan ikke tilgå class properties, er mere 
    public static void MyMethod()
    {
        Console.WriteLine("Called the static method - MyMethod");
               
    }

}



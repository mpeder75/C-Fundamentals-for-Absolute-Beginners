/*

 Constructor er en method der køres når et objekt istancieres (skal hedde det samme som class)

 Constructor bruges til at initialize properties af en instans

 HVIS man IKKE opretter en constructor vil default constructor bruges uanset hvad

 constructor shortcut: ctor+tab+tab

 .this keyword angiver at der peges inde i instancen - this.Make angiver man vil bruge Make property i instansen 
  
*/


// Instans med Hardcoded værdier
Car myCar = new Car();
Console.WriteLine($"Hardcoded object:\nMake: {myCar.Make}\nModel: {myCar.Model}\nYear: {myCar.Year}\nColor: {myCar.Color}\n");


// Instans hvor værdier sættes ved istanciering
Car myNewCar = new Car("Audi", "A6", 2019, "Dark blue");
Console.WriteLine($"Object initialized with values through custom constructor:\nMake: {myNewCar.Make}\nModel: {myNewCar.Model}\nYear: {myNewCar.Year}\nColor: {myNewCar.Color}");





class Car
{
    // Properties - Skal altid starte med STORT forbogstav
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }


    // Hardcode properties med constructor
    public Car()
    {
        Make = "Ferrari";
        Model = "458 italia";
        Year = 2018;
        Color = "racing red";
    }   

    // Overloaded constructor - HUSK for at overloade skal method signature være forskellig
    // Denne constructor tillader at oprette objektet med værdier når den istancieres Car("Audi", "A6"...);
    public Car(string make, string model, int year, string color)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Color = color;
    }

}



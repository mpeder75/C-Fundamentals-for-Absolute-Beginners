/*
 
 Access modifier er modifiers der opsætter hvilken access en properti eller metode har

 public = Alle kan tilgå property eller method - Kan tilgåes udefra

 private = Kan kun tilgåes af medlemmer af en class - Kan IKKE tilgåes udefra


  SØRG FOR at alle "helper methods" i class ser private  


*/



Car myCar = new Car();

// Hvis man skriver myCar. -> Vil HelperMethod ikke være der, den er private, og kan kun tilgåes fra class

// MEN method DoSomething er tilgændelig, da den er public
myCar.DoSomething();




class Car
{
    // public method, der tilgåer privat method HelperMethod
    public void DoSomething()
    {
        Console.WriteLine(HelperMethod());
    }

    // private method, denne er kun tilgændelig indefra Car class, kan ikke tilgåes udefra
    private string HelperMethod()
    {
        return "HelloWorld";
    }

}

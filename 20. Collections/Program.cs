/*todo
  
 List<> er en dynamisk collection - Den kan udvides efter den er declaret  
  
 */

using System.Collections;


Car car1 = new Car();
car1.Make = "Audi";
car1.Model = "A6";

Car car2 = new Car();
car2.Make = "BMW";
car2.Make = "M3";

Book book1 = new Book();
book1.Author = "Robert Tabor";
book1.Title = "Microsoft .NET XML Web Services";
book1.ISBN = "0-000-00000-0";


/* -------------- ArrayList er dynanamiske -------------- */

// opret arraylist
ArrayList myArrayList = new ArrayList();

// Man kan tilføje car & book objekter til arraylisten
myArrayList.Add(car1);
myArrayList.Add(car2);
myArrayList.Add(book1);

//! PROBLEM: Hvis man KUN vil printe Car objekterne ud, kan man IKKE dette 
foreach(Car car in myArrayList)
{
    Console.WriteLine(car.Make);
}

//! Man kan kun printe alle elementerne ud
foreach (var item in myArrayList)
{
    Console.WriteLine(item);
}










class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
}
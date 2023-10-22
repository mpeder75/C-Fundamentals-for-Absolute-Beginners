
// DateTime objekt med tid og dd. - ToString() gør at der printes korrekt ud
DateTime myValue = DateTime.Now;
Console.WriteLine(myValue.ToString());

// Print kun dato og år
Console.WriteLine(myValue.ToShortDateString());

// Print kun tid
Console.WriteLine(myValue.ToShortTimeString());

// Print ugedag, måned og år
Console.WriteLine(myValue.ToLongDateString());

// Print tid ud med sekunder
Console.WriteLine(myValue.ToLongTimeString());



// Lægge 3 dage til dd
Console.WriteLine(myValue.AddDays(3).ToLongDateString());

// Trække 3 dage fra dd
Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

// Lægge 3 timer til nuværendne tid
Console.WriteLine(myValue.AddHours(3).ToLongDateString());

// Printe hvilket nummer måned er i (1-12)
Console.WriteLine(myValue.Month);

// Gemme og printe ens fødselsdag
DateTime myBirthday1 = new DateTime(1982,4,11);
Console.WriteLine($"My birthday is: {myBirthday1.ToShortDateString()}");


// Gemme og printe ens fødselsdag genne en string
DateTime myBirthday2 = DateTime.Parse("11/04/1982");
Console.WriteLine(myBirthday2);

// TimeSpan - Hvor mange dage har man levet - Tidsinterval
TimeSpan myAge = DateTime.Now.Subtract(myBirthday1);
Console.WriteLine(myAge.TotalDays);

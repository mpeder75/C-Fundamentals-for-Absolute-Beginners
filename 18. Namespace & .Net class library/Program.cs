/*
  
 Namespaces bruges for at kunne kende forskel på classes man bruger

 Namespace skal se ses som efternavne for ens classes 
    
 */
using System.Net;




// Skrive til en text fil i directory - !! Fil skal være oprettet på forhånd
string text = "nWe want to write this to our file";
File.WriteAllText(@"c:\demo\writetext.txt", text);



// Hente en hjemmeside og gemme den i en text fil
WebClient client = new WebClient();
string reply = client.DownloadString("http://msdn.microsoft.com");

File.WriteAllText(@"c:\demo\writewebpagetext.txt", reply);






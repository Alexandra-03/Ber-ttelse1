using System;

string svar  = "ja";
string beslut = "öppna";
string objekt = "kartan";


Console.WriteLine("vill du gå in i grottan, ja eller nej?");
Console.ReadLine();

if (svar == "ja")
{
    Console.WriteLine("Du går in och hittar en kista");
}
else
{
    Console.WriteLine("Du kommer till en sjö och ser en segelbåt");
}
Console.ReadLine();


Console.WriteLine("Ska du öppna kistan, öppna eller inte?");
Console.ReadLine();

if (beslut == "öppna")
{
    Console.WriteLine("Du hitter en karta och en nyckel i kistan när den öppnas");
}
else
{
    Console.WriteLine("Du misslyckas och ditt äventyr tar slut");
}
Console.ReadLine();


Console.WriteLine("Täker du ta kartan eller nyckeln från kistan?");
Console.ReadLine();

if (objekt == "kartan")
{
    Console.WriteLine("Kartan visar vägen till ett försvunnet tempel, äventyer fortsätter!!!");
}
else
{
    Console.WriteLine("Nyckln du tar är rostig och går inte att använda, ditt ävertyr är över");
}
Console.ReadLine();



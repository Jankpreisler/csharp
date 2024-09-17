//Dotaznik
using System.Net.Mail;

Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);


Console.WriteLine("Aké je tvoje oblubené jedlo");
string? jedlo = Console.ReadLine();
Console.WriteLine("Ahoj volám sa " + meno + " Mám " + vek + " a moje oblubené jedlo je " + jedlo + "." + "\n");
// Koniec dotaznika

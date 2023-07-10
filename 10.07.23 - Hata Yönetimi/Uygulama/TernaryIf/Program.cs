using System.Threading.Channels;

start:
string gercekAd = "utku";

Console.WriteLine("Benim adım ne?: ");
string girilenAd = Console.ReadLine().ToLower();

string sonuc = gercekAd == girilenAd ? "Aferin." : "Yok abi.";



Console.WriteLine(sonuc);

goto start;

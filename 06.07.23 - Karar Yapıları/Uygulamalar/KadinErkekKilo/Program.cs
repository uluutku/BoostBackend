// Bir kampüsteki öğrencilerin kilo ortalamalarını cinsiyetlerine göre bulduran program
using System.Runtime.CompilerServices;

int erkekSayisi = 0;
int kadinSayisi = 0;
double erkekToplam = 0;
double kadinToplam = 0;
double erkekOrtalama = 0;
double kadinOrtalama = 0;
string cevap;

degerAlma: Console.WriteLine("Cinsiyetinizi Girin: E/K ");
string cinsiyet = Console.ReadLine();

if (cinsiyet != "E" && cinsiyet != "e" && cinsiyet != "K" && cinsiyet != "k")
{
    Console.WriteLine("Lütfen e veya k girin");
    goto degerAlma;
}



Console.WriteLine("Lütfen Kilonuzu Girin: ");
double kilo = double.Parse(Console.ReadLine());


if (cinsiyet == "E" || cinsiyet == "e")
{
    erkekToplam += kilo;
    erkekSayisi++;
}

else if (cinsiyet == "K" || cinsiyet == "k")
{
    kadinToplam += kilo;
    kadinSayisi++;
}

Console.WriteLine("Veri kayededildi.");
Console.WriteLine("Yeni kişi kaydedecek misiniz. E/H ");
cevap = Console.ReadLine();

if (cevap == "E")
{
    goto degerAlma;
}

else if (cevap == "H")
{

    if (kadinSayisi == 0)
    {
        Console.WriteLine("Lütfen en az 1 kadın değeri girin.");
        goto degerAlma;
    }

    if (erkekSayisi == 0)
    {
        Console.WriteLine("Lütfen en az 1 erkek değeri girin.");
        goto degerAlma;
    }


    kadinOrtalama = kadinToplam / kadinSayisi;
    erkekOrtalama = erkekToplam / erkekSayisi;
    Console.WriteLine($" {kadinSayisi} kadının kilo ortalaması: {kadinOrtalama}");
    Console.WriteLine($" {erkekSayisi} erkeğin kilo ortalaması: {erkekOrtalama}");
}



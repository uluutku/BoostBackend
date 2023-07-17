using System.Threading.Channels;
/*
static void Yazdirma(string yazi, int sayi)
{
    for (int i = 1; i <= sayi; i++)
    {
        Console.WriteLine(yazi);
    }
}

Console.WriteLine("Yazılacak Metni Girin: ");
string bilgi = Console.ReadLine();
Console.WriteLine("Kaç Kere Yazılacağını Girin: ");
int adet = int.Parse(Console.ReadLine());

Yazdirma(bilgi, adet);
*/

Console.WriteLine("Metni girin: ");
string metin = Console.ReadLine();

Console.WriteLine("Sayılacak karakteri girin: ");
char karakter = char.Parse(Console.ReadLine());

int sayac = Sayac(metin, karakter);
Console.WriteLine();
Console.WriteLine("Karakterin metin içerisinde geçme sayısı: " + sayac);

static int Sayac(string metin, char karakter)
{
    int sayac = 0;
    foreach (char item in metin)
    {
        if (item == karakter)
        {
            sayac++;
        }
    }
    return sayac;
}
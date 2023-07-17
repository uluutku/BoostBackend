/*

    string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

    foreach (string gun in gunler)
    {
        if (gun == "Cumartesi" || gun == "Pazar")
        {
            Console.WriteLine("Tatil");
        }
        else
        {
            Console.WriteLine(gun);
        }
    }

int[] sayilar = { 435, 43, 543, 53, 53, 7, 645, 3, 5, 435, 46, 5, 56, 435, 3, 443, 565, 5, 654, 53 };

Array.Sort(sayilar);
Console.WriteLine("En kucuk sayi: " + sayilar[0]);
Console.WriteLine("En büyük sayi: " + sayilar[sayilar.Length-1]);
*/


Console.WriteLine("Kaç ürün gireceksin?: ");
int urunSayisi = int.Parse(Console.ReadLine());

string[] urunler = new string[urunSayisi];

for (int i = 0; i < urunSayisi; i++)
{
    Console.WriteLine($"{i+1}. Ürünü girin.");
    urunler[i] = Console.ReadLine();
}

Console.WriteLine("Girilen Ürünler: ");

foreach (string item in urunler)
{
    Console.WriteLine(item);
}
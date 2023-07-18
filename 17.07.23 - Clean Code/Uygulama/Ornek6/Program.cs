// Kullanıcının girdiği iki sayının toplamını ve toplamının küpünü hesaplayan bu hesaplama sonucunda toplamının küpü değerini geriye döndüren fonksiyon.

Console.WriteLine("Birinci sayi: ");
double sayi1 = double.Parse(Console.ReadLine());
Console.WriteLine("İkinci sayı: ");
double sayi2 = double.Parse(Console.ReadLine());


double sonuc = ToplaminKupu(sayi1, sayi2);
Console.WriteLine("İşlemin sonucu: " + sonuc);


Console.WriteLine("Tek mi Çift mi öğrenmek istediğiniz sayıyı girin: ");
double sayi3 = double.Parse(Console.ReadLine());
string tekCift = TekMiCiftMi(sayi3);
Console.WriteLine("Girdiğiniz sayı, " + tekCift);


static double ToplaminKupu(double sayi1, double sayi2 out double toplam)
{
    double toplam = (sayi1 + sayi2);
    double toplamKupu = toplam * toplam * toplam;
    return toplamKupu;
}


static string TekMiCiftMi(double sayi3)
{
    if (sayi3 % 2 == 0)
    {
        return "Çift";
    }

    else
    {
        return "Tek";
    }
}


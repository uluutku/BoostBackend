#region Faktoriyel While Cozum
/*
Console.WriteLine("Lütfen faktöriyeli alınacak sayıyı girin: ");
double sayi = double.Parse(Console.ReadLine());

double faktoriyel = 1;
int sayac = 0;

if (sayi == 0)
{
    Console.WriteLine("Sonuç = 1 dir.");
}

else
{
    while (sayac < sayi)
    {
        sayac++;
        faktoriyel = sayac * faktoriyel;
    }
    Console.WriteLine("Sonuç: " + faktoriyel);
*/
#endregion


#region Dongusuz Faktoriyel Cozum
sayiAl:
Console.WriteLine("Lütfen sayı gir: ");
int sayi = int.Parse(Console.ReadLine());

int faktoriyel = 1, sayac = 1;

if (sayi == 0)
{
    faktoriyel = 1;
    goto ekranaYaz;

}

else if (sayi < 0)
{
    goto negatifSayi;
}

kontrol: if (sayi > sayac)
{
    sayac++;
    faktoriyel *= sayac;
    goto kontrol;
}

goto ekranaYaz;

ekranaYaz: Console.WriteLine($"Girilen sayı: {sayi} Faktoriyeli: {faktoriyel}");
goto bitir;
negatifSayi: Console.WriteLine("Negatif sayı girildi.");
goto sayiAl;
bitir: Console.ReadLine();
#endregion
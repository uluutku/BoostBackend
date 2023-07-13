// kullanıcının girdiği 10 sayıdan 3 basamaklıları bul

int sayac = 1;
int sayiAdet = 0;

do
{
    Console.WriteLine($"Lütfen {sayac}. sayıyı girin: ");
    double girilenSayi = double.Parse(Console.ReadLine());
    
    if (girilenSayi >= 100 && girilenSayi < 1000)
    {
        sayiAdet++;
    }

    if (girilenSayi <= -100 && girilenSayi > -1000)
    {
        sayiAdet++;
    }

    sayac++;
} while (sayac <= 10);

Console.WriteLine($"Girdiğiniz sayılardan {sayiAdet} tanesi 3 basamaklıdır.");
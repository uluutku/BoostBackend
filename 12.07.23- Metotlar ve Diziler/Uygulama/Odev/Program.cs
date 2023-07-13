// For ile

/*
 Console.Write("İlk sayıyı girin: ");
int ilkSayi = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
int ikinciSayi = Convert.ToInt32(Console.ReadLine());

int toplam = 0;

for (int i = ilkSayi; i <= ikinciSayi; i++)
{
    toplam += i;
}

Console.WriteLine("Sayıların toplamı: " + toplam);
*/

// while ile

Console.WriteLine("İlk sayıyı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = 0;
int sayac = sayi1;

while (sayac <= sayi2)
{
    toplam += sayac;
    sayac++;
}

Console.WriteLine("Toplam: " + toplam);
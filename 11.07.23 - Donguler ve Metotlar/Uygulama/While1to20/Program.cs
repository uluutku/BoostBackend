using System.Net.WebSockets;

int sayac = 1;
int sayac2 = 1;
int sayac3 = 1;
int sayac4 = 1;
int sayac5 = 1;
double sayi1 = 1;
double toplam = 0;
double toplam2 = 0;

while (true)
{
    Console.WriteLine(sayac);
    sayac++;
    
    if (sayac == 21)
    {
        break;
    }
}

Console.WriteLine("********");

while (sayac2 <= 20)
{
    Console.WriteLine(sayac2);
    sayac2++;
}

Console.WriteLine("********");

while (sayac3 <= 100)
{
    if (sayac3 % 2 == 0)
    {
        toplam += sayac3;
    }
    sayac3++;
}

Console.WriteLine("1 den 100 e kadar çift sayıların toplamı: " + toplam);

Console.WriteLine("********");

while (sayac4 <= 10)
{
    Console.WriteLine($"{sayac4} * 7 = " + sayac4 * 7);
    sayac4++;
}

while (true)
{
    Console.WriteLine("Lütfen sayı giriniz:");
    sayi1 = double.Parse(Console.ReadLine());
    
    if(sayi1 == 0)
    {
        break;
    }

    Console.WriteLine("Sayının kendisi: " + sayi1);
    Console.WriteLine("Sayının karesi: " + sayi1 * sayi1);
}

Console.WriteLine("************");

while (sayac5 <= 100)
{
    toplam2 += sayac5;
    sayac5++;
}

Console.WriteLine("1 den 100 e kadar sayıların toplamı: " + toplam2);

Console.WriteLine("********");

int faktoriyel = 1;
Console.WriteLine("Lütfen sayı giriniz:");
int sayi7 = int.Parse(Console.ReadLine());
int sayac7 = 2;

while (sayac7 <= sayi7)
{ 
    faktoriyel *= sayac7;
    sayac++;
}

Console.WriteLine("Faktoriyel bu:" + faktoriyel);

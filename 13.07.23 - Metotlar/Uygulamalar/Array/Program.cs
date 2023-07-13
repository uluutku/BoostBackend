using System.Collections;
using System.Collections.Immutable;

/*
int[] dizi = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Lütfen bir sayı girin: ");
    dizi[i]=(int.Parse(Console.ReadLine()));
    //dizi.Append(int.Parse(Console.ReadLine());
}

Array.Sort(dizi);
Console.WriteLine(dizi[5]);
*/

//
/*
int[] dizi = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Lütfen bir sayı girin: ");
    dizi[i] = (int.Parse(Console.ReadLine()));
    //dizi.Append(int.Parse(Console.ReadLine());
}

Array.Sort(dizi);
Array.Reverse(dizi);
*/

/*

int[] dizi = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Lütfen bir sayı girin: ");
    dizi[i] = (int.Parse(Console.ReadLine()));
}
 
for (int i = 0; i <= dizi.Length; i++)
{
    for (int j = i + 1; j < dizi.Length; j++)
    {
        if (dizi[i] <= dizi[j])
        {
            int temp = dizi[i];
            dizi[i] = dizi[j];
            dizi[j] = temp;
        }
    }
}

Console.WriteLine();

foreach (var item in dizi)
{
    Console.WriteLine(item);
}

*/

// Ödev: klavyeden kullanıcı tarafından girilen 5 ismi alfabetik olarak sıralayan programı array kullanarak yazınız. (array metotları kullanılmayacak)

// klavyeden kullanıcı tarafından girilen beş elemanlı bir sayı dizinde son rakamı 0(sıfır) olan sayıların sayısını bulan programı yazınız


/*
//10 elemanlı bir dizinin elemanları 1-1000 arasında bilgisayar tarafından rasgele atanacaktır. Bu dizideki 500 - 600 arasındaki sayıların toplamı ile 100-500 arasındaki sayıların sayısını bulan program.
int sayac = 0;
double araToplam = 0;
int[] sayilar = new int[10];

for (int i = 0; i < 10; i++)
{
    Random rnd = new Random();
    sayilar[i] = Convert.ToInt32(rnd.Next(1, 1000));
}

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] >= 500 && sayilar[i] <= 600)
    {
        araToplam += sayilar[i];
    }
}

for (int j = 0;  j < sayilar.Length; j++)
{
    if (sayilar[j] >= 500 && sayilar[j] <= 600)
    {
        sayac++ ;
    }
}

Console.WriteLine("Sayıların Toplamı: " + araToplam);
Console.WriteLine("Sayıların Sayısı: " + sayac);

Console.WriteLine("****************");

Console.WriteLine("Rasgele gelen sayılar: ");
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}
*/



// gelistirme

int sayac = 0;
double araToplam = 0;
int[] sayilar = new int[10];

for (int i = 0; i < 10; i++)
{
    Random rnd = new Random();
    sayilar[i] = Convert.ToInt32(rnd.Next(1, 1000));
    if (sayilar[i] >= 500 && sayilar[i] <= 600)
    {
        araToplam += sayilar[i];
    }
    if (sayilar[i] >= 500 && sayilar[i] <= 600)
    {
        sayac++;
    }
}

Console.WriteLine("Sayıların Toplamı: " + araToplam);
Console.WriteLine("Sayıların Sayısı: " + sayac);

Console.WriteLine("****************");

Console.WriteLine("Rasgele gelen sayılar: ");
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

// odev3: sayısıal loto programı: 6 random sayı arka planda - 6 sayı girilecek - =>2 sayı girilirse kazandınız diyicek
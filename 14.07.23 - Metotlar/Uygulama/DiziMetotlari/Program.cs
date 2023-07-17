// DİZİ METOTLAR

/* Dizi Özellikleri ve Metotları
* Dizi olarak tanımladığımız değişkenlerin Array sınıfından türemiş olduklarından dolayı sahip olduğu özellikler ve metotları vardır.  
*/


/* ÖZELLİKLERİ

* Length: Dizideki eleman sayısını verir.(int)

* IsReadOnly: Dizideki elemanların sadece okunabilir olup olmadığını söyler.(bool)

* IsFixedSize: Dizinin eleman sayısının sabit olup olmadığı verir.(bool)

* Rank: Dizinin boyutunu verir.(int)

* 

* ---------------------------------------------------------------------------

* METOTLARI

* Sort(): Bir boyutlu dizileri sıralamaya yarar.

* Reverse(): Diziyi tersine çevirir.

* Copy(): Dizinin bir bölümünü başka bir diziye kopyalar. Gerekli tür dönüştürme ve boxing işlemleri yapılır.

* CopyTo(): Diziyi kopyalar.

* IndexOf(): Dizi içerisindeki bir değerin indeksini verir.

* SetValue():Bir dizinin bir elemanına değer atar.

* GetLength(): Dizideki eleman sayısını verir.

* Resize(): Yeniden boyutlandırmayı sağlar.

* GetValue(): Dizideki ilgili elemanın değerini verir.

* Clear(): Dizinin elemanlarını varsayılan değere çeker.
*/

/*

string[] dizi = { "Bilge", "Adam", "Boost", "Yıldız", "Yazılımcı" };

foreach (var d in dizi)
{
    Console.WriteLine(d);
}

Console.WriteLine("**********");

Array.Resize(ref dizi, 2);

Console.WriteLine("Dizi 2 ye küçültülünce: ");
Console.WriteLine();

foreach (var d in dizi)
{
    Console.WriteLine(d);
}

Console.WriteLine("**********");


Array.Resize(ref dizi, 7);

Console.WriteLine("Dizi 7 ye büyütülünce: (eski tadı yok) ");
Console.WriteLine("**********");

foreach (var d in dizi)
{
    Console.WriteLine(d);
}

Console.WriteLine("**********");

*/

/*
Random rnd = new Random();
int bolunenSayisi = 0;
int[] randomSayilar = new int[30]; // olusturma
int sayac = 0;
int tamBolunenSayisi = 0;

//doldurma

for (int i = 0; i < randomSayilar.Length; i++)
{
    randomSayilar[i] = (int)(rnd.Next(1, 10001));
}

foreach (int i in randomSayilar)
{
    if (i % 2 == 0)
    {
        bolunenSayisi++;
    }
    if (i % 2 == 0 && i % 3 == 0) 
    {
        tamBolunenSayisi++; 
    }
}

int[] ikiyeBolunenler = new int[bolunenSayisi++];

foreach (int j in randomSayilar)
{
    if (j % 2 == 0)
    {
        ikiyeBolunenler[sayac] = j;
        sayac++;
    }
}

Console.WriteLine("2 ile bölünenler küçükten büyüğe: ");
Array.Sort(ikiyeBolunenler);

foreach (var item in ikiyeBolunenler)
{
    Console.WriteLine(item);
}

Console.WriteLine("2 ve 3 e bölünen sayı adeti: " + tamBolunenSayisi);
*/


/*
int[] arr = { 1, 2, 9, 3, 8, 6, 20, 8, 2, 7 };
int ilkGorulme = Array.IndexOf(arr, 2);
int sonGorulme = Array.LastIndexOf(arr, 2);
Console.WriteLine(ilkGorulme);
Console.WriteLine(sonGorulme);
*/

//10 elemanlı bir adet dizi tanımlayıp. birinciDizi yi ikinci bir dizi oluşturup kopyalayın.

int[] arr = { 1, 3, 5, 6, 7, 54, 35, 67, 2, 10 };
int[] arr2 = new int[10];
Array.Copy(arr, arr2, 10);

foreach (int i in arr)
{
    Console.WriteLine(i);
}

Console.WriteLine("***********");

foreach (var item in arr2)
{
    Console.WriteLine(item);
}


Console.Write("Sayı 1: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Sayı 2: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int carpim = 0;

for (int i = 0; i < sayi2; i++)
{
    carpim += sayi1;
}

Console.WriteLine("Sonuç: " + carpim);
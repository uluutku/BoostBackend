using System;

public class Program
{
    public static void Main()
    {
        string[] dizi = { "Fatma", "Girik", "Tarık", "Akan", "Perihan", "Savaş", "Kadir", "İnanır", "Türkan", "Şoray", "Kemal", "Sunal" };

        // Diziyi 2 sütunlu şekilde paylaşma
        for (int i = 0; i < dizi.Length; i += 2)
        {
            Console.WriteLine($"{dizi[i],-10} {dizi[i + 1]}");
        }

        // Neco'yu dizinin sonuna ekleme
        string yeniOyuncu = "Neco";
        Array.Resize(ref dizi, dizi.Length + 1);
        dizi[dizi.Length - 1] = yeniOyuncu;

        Console.WriteLine("\nDiziye Neco eklendi:");
        for (int i = 0; i < dizi.Length; i += 2)
        {
            if (i + 1 < dizi.Length)
                Console.WriteLine($"{dizi[i],-10} {dizi[i + 1]}");
            else
                Console.WriteLine($"{dizi[i]}");
        }
    }
}
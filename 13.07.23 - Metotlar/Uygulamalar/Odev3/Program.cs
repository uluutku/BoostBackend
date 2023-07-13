    int[] sayilar = new int[5];
    int sifirSonSayiAdet = 0;

    for (int i = 0; i < 5; i++)
    {   
        Console.WriteLine($"Lütfen {i+1}. sayıyı girin.");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());

        if (sayilar[i] % 10 == 0)
        {
        sifirSonSayiAdet++;
        }
    }

    Console.WriteLine("Son rakamı 0 olan sayıların sayısı: " + sifirSonSayiAdet);

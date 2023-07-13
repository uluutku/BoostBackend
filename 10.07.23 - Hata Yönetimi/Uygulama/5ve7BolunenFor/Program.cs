double toplam = 0;
for (int i = 0; i <= 1000; i++)

{
    if (i % 5 == 0)
    {
        if (i % 7 != 0)
        {
            Console.WriteLine(i);
            toplam = toplam + i;
        }
    }
}

Console.WriteLine("Sayıların toplamı: " + toplam);

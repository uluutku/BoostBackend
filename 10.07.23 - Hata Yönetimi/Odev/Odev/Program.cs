Random rnd = new Random();

Random rastgele = new Random();

    for (int i = 0; i < 10; i++)
    {
    double randomSayi = rastgele.NextDouble();
    double aralikSayi = randomSayi * 10 + 10;
    Console.WriteLine(aralikSayi);
    }
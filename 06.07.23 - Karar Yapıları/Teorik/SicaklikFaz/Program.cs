Console.WriteLine("Suyun sıcaklığını girin: ");
double suSicakligi = double.Parse(Console.ReadLine());

if (suSicakligi < 0)
    Console.WriteLine("Su katı haldedir.");
else if (suSicakligi == 0)
    Console.WriteLine("Su katı ve sıvı haldedir.");
else if (suSicakligi > 0 && suSicakligi < 100)
    Console.WriteLine("Su sıvı haldedir.");
else if (suSicakligi == 100)
    Console.WriteLine("Su sıvı ve buhar halindedir.");
else
    Console.WriteLine("Su buhar halindedir.");
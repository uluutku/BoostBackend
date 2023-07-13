Console.WriteLine("******* MATH *******");
Console.WriteLine();

Console.WriteLine("Sayı girin:");
double sayi = double.Parse(Console.ReadLine());

double kok = (double)Math.Sqrt(sayi); // Square Root - Kök Alma (9 -> 2)
double kare = (double)Math.Pow(sayi, 2); // Power - Üs Alma (2,2 -> 4 && 9,2 -> 81)
double yuvarlanmis = (double)Math.Round(sayi); // Normal Yuvarlama (15.5 -> 16 && 14.5 -> 14 çifte yuvarlar)
double yukariYuvarla = (double)Math.Ceiling(sayi); // Yukarı yuvarlama (2.000001 -> 3)
double asagiYuvarla = (double)Math.Floor(sayi); // Aşağı yuvarlama (2.9999 -> 2)
double mutlakDeger = (double)Math.Abs(sayi); // Mutlak değer ( -5 -> 5)

Console.WriteLine("Kökü: " + kok);
Console.WriteLine("Karesi: " + kare);
Console.WriteLine("Yuvarlanmis: " + yuvarlanmis);
Console.WriteLine("Yukari Yuvarlanmis: " + yukariYuvarla);
Console.WriteLine("Asaği Yuvarlanmis: " + asagiYuvarla);
Console.WriteLine("Mutlak Değer: " + mutlakDeger);


// Datetime
Console.WriteLine();
Console.WriteLine("******** DATE TIME *********");
Console.WriteLine();


Console.WriteLine("Anlık Tarih: " + DateTime.Now.ToShortDateString());
Console.WriteLine("Anlık Zaman: " + DateTime.Now.ToShortTimeString());

Console.WriteLine();

DateTime simdi = DateTime.Now;
int yil = simdi.Year;
int ay = simdi.Month;
int gun = simdi.Day;
int saat = simdi.Hour;
int dakika = simdi.Minute;
int saniye = simdi.Second;
int milisaniye = simdi.Millisecond;

Console.WriteLine($"Yıl: {yil}");
Console.WriteLine($"Ay: {ay}");
Console.WriteLine($"Gün: {gun}");
Console.WriteLine($"Saat: {saat}");
Console.WriteLine($"Dakika: {dakika}");
Console.WriteLine($"Saniye: {saniye}");
Console.WriteLine($"Milisaniye: {milisaniye}");

Console.WriteLine();
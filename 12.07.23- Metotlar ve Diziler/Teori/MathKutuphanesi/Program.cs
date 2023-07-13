

int sayi = -123;

sayi = Math.Abs(sayi);
Console.WriteLine("-123 değerinin mutlak değeri: " + sayi);

double sayi2 = 20.6;
double sayi3 = 20.4;

sayi2 = Math.Round(sayi2); 
sayi3 = Math.Round(sayi3);

Console.WriteLine(sayi2);
Console.WriteLine(sayi3);

// 14.5 -> 14
// 15.5 -> 16 // en yakın çift sayıya yuvarlar.


sayi3 = Math.Floor(sayi3);
sayi3 = Math.Ceiling(sayi3);

sayi3 = Math.Sqrt(sayi3); // kare kök

sayi3 = Math.Pow(sayi3, 5); // kuvvet

sayi3 = (float)Math.Pow(sayi3, 1 / 3.0); // kuvvet


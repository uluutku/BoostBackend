vizeAl: Console.WriteLine("Vize Notunuzu Girin: ");
double vize = double.Parse(Console.ReadLine());

if (vize > 100 || vize < 0)
{
Console.WriteLine("Lütfen insan gibi değer girin.");
goto vizeAl;
}

finalAl:  Console.WriteLine("Final Notunuzu Girin: ");
double final = double.Parse(Console.ReadLine());

if (final > 100 || final < 0)
{
    Console.WriteLine("İnsan gibi değer girin.");
    goto finalAl;
}

double notOrt = (vize + final) / 2;

if (notOrt >= 80 && notOrt < 100)
{
    Console.WriteLine("AA");
}
else if (notOrt >= 50 && notOrt < 80)
{
    Console.WriteLine("CC");
}
else
{
    Console.WriteLine("FF");
}


Console.WriteLine("Sütun sayısını girin: ");
int satir = int.Parse(Console.ReadLine());

Console.WriteLine("Satır sayısını girin:");
int sutun = int.Parse(Console.ReadLine());

for (int i = 0; i < sutun; i++)
{
    Console.WriteLine(new String('*', satir));
}

/*

int satir, sutun;

Console.Write("Sütun uzunluğunu girin: ");
satir = int.Parse(Console.ReadLine());

Console.Write("Satır uzunluğunu girin: ");
sutun = int.Parse(Console.ReadLine());

for (int i = 0; i < satir; i++)
{
    for (int j = 0; j < sutun; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

*/
//Array.Sort ile:
/*
string[] isimler = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"İsim {i + 1}: ");
    isimler[i] = Console.ReadLine();
}

Array.Sort(isimler);

Console.WriteLine();
Console.WriteLine("Alfabetik sıralanmış isimler:");
Console.WriteLine();
foreach (var item in isimler)
{
    Console.WriteLine(item);
}
*/

//Array.Sort Kullanmadan:

string[] isimler = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"İsim {i + 1}: ");
    isimler[i] = Console.ReadLine();
}

for (int i = 0; i < isimler.Length - 1; i++)
{
    for (int j = 0; j < isimler.Length - i - 1; j++)
    {
        if (string.Compare(isimler[j], isimler[j + 1]) > 0)
        {
            string temp = isimler[j];
            isimler[j] = isimler[j + 1];
            isimler[j + 1] = temp;
        }
    }
}

Console.WriteLine();
Console.WriteLine("Alfabetik sıralanmış isimler:");
Console.WriteLine();
foreach (var item in isimler)
{
    Console.WriteLine(item);
}
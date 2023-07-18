// 1 den 100 e kadar olan sayıları aralarından birer TAB boşluk olacak şekilde yan yana yazanı çağır.

//Yazidir();
Yazdir2(1,100);

void Yazidir()
{
	for (int i = 1; i <= 100; i++)
	{
        Console.Write(i + "\t"); // \t bir tab boşluk
    }
}

void Yazdir2(int basla, int hedef)
{
    for (int i = basla; i <= hedef; i++)
    {
        Console.Write(i + "\t");
    }
}

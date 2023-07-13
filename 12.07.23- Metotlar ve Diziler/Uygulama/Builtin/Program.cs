

//Atlama deyimleri

/*
 * Bir programda akışı farklı noktalara yönlendirmek için kullanılırlar. (keywordler)
 */

// break, continue, goto, return kelimeleridir.

// döngüden çıkmayı sağlar.

while (true)
{
    Console.WriteLine("Bişey girin:");
    string cevap = Console.ReadLine().ToLower();
    if (cevap == "j")
    {
        break;
    }

}
// C# dilinde bazı veri tipleri doğrudan ramde kendisi ile beraber saklanırken bazı veri tipleri referansları ile birlikte saklanır.

// int, double, char gibi veri tipleri ramde doğrudan kendisi ile birlikte tutulurken, string, class gibi veri tipleri referans olarak saklanır, referans olarak saklanan verilerde verinin kendisi yerine bellekteki adresi tutulur.

// Ramde iki ana bölüm bulunur birincisi Heap ikincisi Stack bölümüdür.

// Boxing, int gibi değer türünden bir değilkeni referans türünde olan bir veriye yerleştirme anlamına gelir. Bu yapıldığında bellekte yeni bir alan kullanıldığından bir miktar performans kaybı yaratabilir ancak istediğimiz veriyi obje tipine dönüştürebilmiş oluruz.

// Boxing işlemi yapıldığında stack bölümünde duran int gibi değerler heap bölümünde bir obje oluşturarak buna stack bölümünden referans verilir. Böylece referans türü ile kullanılmak istendiğinde artık kullanılabilir.



// Unboxing işlemi ise boxing yapılmış bir verinin tersine çevrilmesini ifade eder. Heap bölümünde referans türünde bir veriye ulaşılıp içindeki veri tipi alınır ve stack bölümündeki değişkene atanır. Bu adım da ekstra bir işlem olduğundan yine bir performans kaybı yaratabilir.

// Ozet olarak int gibi değer türlerini referans türlerine dönüştürmek istendiğinde boxing, tersi istendiğinde unboxing işlemi uygulanır.

//----------------------------------------


int sayi = 28; // normal bir int değişken tanımlama

object boxedSayi = sayi; // Boxing işlemi, ile int verinin objecte dönüştürülmesi.

int unboxedSayi = (int)boxedSayi; // Unboxing işlemi, objectin intee dönüştürülmesi


//Boxing işlemi sonucunda yeni ve farklı bir obje oluştuğu için referanslar farklı olur

Console.WriteLine("Normal Sayı: " + sayi);
Console.WriteLine("Boxed Sayı: " + boxedSayi); 
Console.WriteLine("Unboxed Sayı: " + unboxedSayi);

// Burada değerler aynı gibi görünse de aslında sayi ve boxedSayi nın referansları farklıdır.






// Yeni bir dizi oluşturma
int[] numbers = new int[5]; // 5 elemanlı bir integer dizisi oluşturuluyor

// Diziye değer atama
numbers[0] = 1; // İlk elemana değer atama
numbers[1] = 2; // İkinci elemana değer atama
numbers[2] = 3; // Üçüncü elemana değer atama
numbers[3] = 4; // Dördüncü elemana değer atama
numbers[4] = 5; // Beşinci elemana değer atama

// Dizi uzunluğunu alma
int length = numbers.Length; // Dizinin uzunluğunu belirten özellik

// Dizinin belirli bir elemanına erişim
int firstElement = numbers[0]; // İlk elemana erişim
int lastElement = numbers[length - 1]; // Son elemana erişim

// Dizi elemanlarını sıralama
Array.Sort(numbers); // Diziyi küçükten büyüğe doğru sıralar

// Dizi içinde eleman arama
int indexOfThree = Array.IndexOf(numbers, 3); // 3 değerine sahip elemanın indeksini bulma

// Dizi içinde elemanların var olup olmadığını kontrol etme
bool containsFive = numbers.Contains(5); // 5 değerine sahip elemanın dizide olup olmadığını kontrol etme

// Dizi elemanlarını tersine çevirme
Array.Reverse(numbers); // Dizinin elemanlarını tersine çevirir

// Dizi elemanlarını birleştirme
string joinedString = string.Join(", ", numbers); // Dizinin elemanlarını belirli bir ayraçla birleştirir

int[] numbers2 = { 1, 2, 3, 4, 5 };

// for döngüsü kullanarak dizi elemanlarını gezme
for (int i = 0; i < numbers2.Length; i++)
{
    int element = numbers2[i];
    // Elemanla yapılacak işlemler
    Console.WriteLine(element);
}

// foreach döngüsü kullanarak dizi elemanlarını gezme
foreach (int element in numbers2)
{
    // Elemanla yapılacak işlemler
    Console.WriteLine(element);
}

int[] numbers3 = { 3, 1, 4, 2, 5 };

// Sıralama algoritması kullanmadan diziyi sıralama
for (int i = 0; i < numbers3.Length - 1; i++)
{
    for (int j = i + 1; j < numbers3.Length; j++)
    {
        if (numbers3[j] < numbers3[i])
        {
            // Elemanları yer değiştirme
            int temp = numbers3[i];
            numbers3[i] = numbers3[j];
            numbers3[j] = temp;
        }
    }
}

// Sıralanmış diziyi yazdırma
foreach (int element in numbers3)
{
    Console.Write(element);
}
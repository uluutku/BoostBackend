/* ------------- DEĞİŞKEN TANIMLAMA KURALLARI --------------
// 1. Anahtar Kelimeler kullanılamaz. (while - if - int gibi)
// 2. İsimlendirme Kuralları:
//    - İsimler harf veya alt çizgi ile başlamalıdır. Sayı ile başlayamaz.
//    - İsimler yalnızca harf, rakam ve alt çizgi karakterlerini içerebilir.
//    - Değişken adları büyük/küçük harfe duyarlıdır.
// 3. İsim Uzunluğu en az bir karakter olmalıdır ve maksimum 511 karakterle sınırlıdır.
// 4. İsim Çakışması: Bir öğeyle (değişken, fonksiyon, sınıf vb.) aynı ismi paylaşan bir değişken adı kullanılamaz.
// 5. İsimlendirme Standartlarına uyulmalıdır.
// 6. Değişken isimleri ne kadar anlaşılır olursa daha iyi. (h -> boy -> girilenBoy)
*/

// Doğru Değişken İsimleri:

int age;
string fullName;
double averageScore;
bool isStudent;
char firstLetter;

// Yanlış Değişken İsimleri:
// float 123height; // Geçersiz - sayı ile başlayan değişken adı
// bool if; // Geçersiz - anahtar kelime kullanıldı
// string first name; // Geçersiz - boşluk kullanıldı
long veryLongVariableNameWithMultipleWords; // Geçerli, ancak çok uzun ve pek tavsiye edilmez

// ------------- VERİ TİPLERİ --------------
// (Ram Kullanımına göre küçükten büyüğe doğru)

// Boolean
bool isTrue = true; // Bir ifadenin doğru olduğunu temsil eder
bool isFalse = false; // Bir ifadenin yanlış olduğunu temsil eder

// Karakterler
char character = 'A'; // Bir karakteri temsil eder

// Tamsayılar
sbyte smallNumber = -10; // -128 ile 127 arasındaki küçük bir sayıyı temsil eder
byte positiveByte = 200; // 0 ile 255 arasındaki pozitif bir sayıyı temsil eder
short shortNumber = -30000; // -32,768 ile 32,767 arasındaki bir sayıyı temsil eder
ushort positiveShort = 60000; // 0 ile 65,535 arasındaki pozitif bir sayıyı temsil eder
int integer = -1000000; // -2,147,483,648 ile 2,147,483,647 arasındaki bir sayıyı temsil eder
uint positiveInteger = 2000000; // 0 ile 4,294,967,295 arasındaki pozitif bir sayıyı temsil eder
long longNumber = -1234567890L; // -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasındaki bir sayıyı temsil eder
ulong positiveLong = 9876543210UL; // 0 ile 18,446,744,073,709,551,615 arasındaki pozitif bir sayıyı temsil eder

// Ondalıklı Sayılar
float floatValue = 3.14f; // Yaklaşık 6-9 haneli ondalıklı bir sayıyı temsil eder
double doubleValue = 3.14159; // Yaklaşık 15-17 haneli ondalıklı bir sayıyı temsil eder
decimal decimalValue = 3.1415926535897932384626433832m; // Yaklaşık 28-29 haneli ondalıklı bir sayıyı temsil eder

// Tarih ve Saat
DateTime currentDate = DateTime.Now; // Geçerli tarih ve saati temsil eder

// Metin
string text = "Hello, World!"; // Bir metni temsil eder
string sayi = "12145315"; // Sayı olarak gözükse de aslında string tipinde sayılar da karakterdir. Mat işlemleri için convert edilir.


// --------- VERİ TİPLERİNİN RAMDE TUTTUKLARI YER MİKTARI (KÜCÜKTEN BUYUĞE) ------------

// 1. Boolean: 1 bit
// 2. Karakterler:
//    - char: 2 byte
// 3. Tamsayılar:
//    - sbyte: 1 byte
//    - byte: 1 byte
//    - short: 2 byte
//    - ushort: 2 byte
//    - int: 4 byte
//    - uint: 4 byte
//    - long: 8 byte
//    - ulong: 8 byte
// 4. Ondalıklı Sayılar:
//    - float: 4 byte
//    - double: 8 byte
//    - decimal: 16 byte
// 5. Tarih ve Saat:
//    - DateTime: 8 byte
// 6. Metin:
//    - string: Değişken boyutta
// 7. Nesne Referansları:
//    - object: Değişken boyutta


decimal ondalikDeger = 3.14m;
string metinDegeri = "Merhaba, Dünya!";
sbyte sbyteDegeri = -42;
double ciftOndalikDeger = 3.14159;
bool mantikDegeri = true;
float kayanOndalikDeger = 3.5f;
short kisaDeger = 100;
long uzunDeger = 1000000;

Console.WriteLine("ondalikDeger: " + ondalikDeger);
Console.WriteLine("metinDegeri: " + metinDegeri);
Console.WriteLine("sbyteDegeri: " + sbyteDegeri);
Console.WriteLine("ciftOndalikDeger: " + ciftOndalikDeger);
Console.WriteLine("mantikDegeri: " + mantikDegeri);
Console.WriteLine("kayanOndalikDeger: " + kayanOndalikDeger);
Console.WriteLine("kisaDeger: " + kisaDeger);
Console.WriteLine("uzunDeger: " + uzunDeger);

Console.WriteLine(ondalikDeger.GetType());
Console.WriteLine(metinDegeri.GetType());
Console.WriteLine(sbyteDegeri.GetType());
Console.WriteLine(ciftOndalikDeger.GetType());
Console.WriteLine(mantikDegeri.GetType());
Console.WriteLine(kayanOndalikDeger.GetType());
Console.WriteLine(kisaDeger.GetType());
Console.WriteLine(uzunDeger.GetType());

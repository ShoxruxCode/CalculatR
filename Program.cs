using System;

Console.WriteLine("1-vazifa boshlandi");
// 1-vazifa sharti :
// 1. Doira yuzi va aylana uzunligini hisoblash
// Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va 
// aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
// Input: radius=3
// Output: S=28.2743338823081, L=18.8495559215388
// --------------
// Input: radius=4.23
// Output: S=56.2122031914168, L=26.5778738493697

// Dastur kodi :
Console.Write("Radiusni kiriting : ");
string radiusAsString = Console.ReadLine();
double radius = Convert.ToDouble(radiusAsString);
double PI = Math.PI;
double S = PI * Math.Pow(radius,2);
double L = 2 * PI * radius;
Console.WriteLine($"Doira yuzi : {S}");
Console.WriteLine($"Aylana uzunligi : {L}");
Console.WriteLine("1-vazifa yakunlandi");
// Dastur yakunlandi
Console.WriteLine("2-vazifa boshlandi");
// 2-vazifa sharti :
// 2. Valyuta konvertri
// Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini 
// e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
// Input: qiymat=2, kurs=12400 so’m
// Output: 24800 so’m
// ----------------
// Input: qiymat=7.6, kurs=12400 so’m
// Output: 94240 so’m

// Dastur kodi :
Console.Write("Summaning qiymatini kiriting : ");
double qiymat = Convert.ToDouble(Console.ReadLine());
Console.Write("Valyuta kursini kiriting : ");
double kurs = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Konvertatsiya qilingan summa hisoblandi : {qiymat * kurs}");
Console.WriteLine("2-vazifa yakunlandi");
// Dastur yakunlandi
Console.WriteLine("3-vazifa boshlandi");
// 3-vazifa sharti :
// 3. Yoshni hisoblash
// Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda 
// ifodalang. Kabisa yilini hisobga olmang
// Input: x=2004
// Output: 6935
// -----------------
// Input: x= 1996
// Output: 9855

// Dastur kodi :
Console.Write("Tug'ilgan yilingizni kiriting : ");
int birthYear = Convert.ToInt32(Console.ReadLine());
int age = 2024 - birthYear;
int daysInOneYear = 365;
Console.WriteLine($"Sizning yoshingiz kunlarda hisoblandi : {age * daysInOneYear}");
Console.WriteLine("3-vazifa yakunlandi");
// Dastur yakunlandi
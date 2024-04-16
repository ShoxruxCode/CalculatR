using System;

// Basics.Tanlash bo’limi uchun 3-amaliy vazifa
// 1-topshiriq
// Palindrome Tekshiruvi: Palindrom, so'zning boshidan
// oxiriga qadar o'qilgandagi tartibida ham, oxiridan boshiga
// qadar o'qilgandagi tartibida ham bir xil bo'lgan so'z yoki
// satrdir. Misol uchun, "kayak", "radar" va "level" so'zlari
// palindromlarga misol bo'lishi mumkin. Sizdan kiritilgan
// satrning palindrom bo'lishini tekshiruvchi dastur yozishni
// so'raymiz. Agar kiritilgan satr palindrom bo'lsa, dastur
// "Palindrom" degan xabarni chiqaradi, aks holda
// "Palindrom emas" degan xabarni chiqaradi.
// Input: "kayak"
// Output: "Palindrom"
Console.Write("Palindrom bo'lgan biron bir kichik harflardan iborat so'z kiriting: ");
string matnPalindromga = Console.ReadLine();
int length = matnPalindromga.Length;

if(PalindromGaTekshir(matnPalindromga))
{
    Console.WriteLine($"{matnPalindromga} - Palindrom so'z");
}
else
{
    Console.WriteLine($"{matnPalindromga} - Palindrom so'z emas");
}

bool PalindromGaTekshir(string matnPalindromga)
{
    for (int i = 0; i < length / 2; i++)
    {
        if (matnPalindromga[i] != matnPalindromga[length - i - 1])
        {
            return false;
        }
    }
    return true;
}
// 2-topshiriq
// Temperatura o'girish: Foydalanuvchidan o'zbek tilida 
// graduslar (Selsiyus) bo'yicha temperaturani kiritishni
// so'rang. Keyin kiritilgan temperaturani Fahrenheit va
// Kelvin ga o'girib, natijalarni ekranga chiqaring.
// Switch-operatoridan foydalaning.
// Input: 25
// Output: Selsiyus: 25, Fahrenheit: 77.0, Kelvin: 298.15
Console.Write("Temperaturani kiriting (Selsiyus): ");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = 0.0;
switch (celsius){
    case double temperatura when (temperatura >= -273.15):
        fahrenheit = celsius * 9 / 5 + 32;
    break;
    default:
        Console.WriteLine("Noto'g'ri temperatura kiritildi");
    break;
}
double kelvin = celsius + 273.15;
Console.WriteLine($"Selsiyus: {celsius}, Fahrenheit: {fahrenheit}, Kelvin: {kelvin}");
// 3-topshiriq
// Sonlarni tartiblash: Foydalanuvchidan o'zbek tilida
// sonlarni kiritishni so'rang. Keyin kiritilgan sonlarni
// tartiblangan qator (ascending) va teskari tartib
// (descending) bo'ylab ekranga chiqaring.
// Switch-operatoridan foydalaning.
// Input: 9, 4, 7, 2, 5
// Output:
// Tartiblangan qator: 2, 4, 5, 7, 9
// Teskari tartib: 9, 7, 5, 4, 2
Console.Write("Kiritmoqchi bo'lgan butun sonli massiv to'plamning uzunligini kiriting: ");
int massivUzunligi = Convert.ToInt32(Console.ReadLine());
int [] array = new int[massivUzunligi];
Console.WriteLine("To'plam massiv elementlarini kiriting: ");
for(int i = 0; i < massivUzunligi; i++)
{
    Console.Write($"array[{i+1}]=");
    array[i] = int.Parse(Console.ReadLine());
}
Console.Write("Boshlang'ich massiv: ");
foreach (int num in array)
{
    Console.Write(num + " ");
}
Console.WriteLine();
Console.WriteLine("1 - Tartiblangan qator\n2 - Teskari tartib");
Console.Write("Amalni tanglang: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Tartiblangan_qator();
        break;
    case 2:
        Teskari_tartib();
        break;
    default:
        Console.WriteLine("Noto'g'ri amal tanlandi!");
        break;
}
void Tartiblangan_qator()
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int ozlashtir = array[i];
                array[i] = array[j];
                array[j] = ozlashtir;
            }
        }
    }
    Console.Write("Tartiblangan qator: ");
    foreach (int num in array)
    {
        Console.Write(num + " ");
    }
}
void Teskari_tartib()
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                int ozlashtir = array[i];
                array[i] = array[j];
                array[j] = ozlashtir;
            }
        }
    }
    Console.WriteLine();
    Console.Write("Teskari tartib: ");
    foreach (int num in array)
    {
        Console.Write(num + " ");
    }
}
// Agar bu massivni bu kabi algoritmlash kerak bo'lmasa Array sinfining tayyor 
// metodlari bor bular : Array.Sort va Array.Reverse.
// shularni ishlatib qo'ysa tayyor tartiblanadi yoki teskari tartiblanadi.

// 4-topshiriq
// Berilgan matnning simvol sanasini hisoblash:
// Foydalanuvchidan bir matn kiritishni so'rang. Keyin,
// kiritilgan matndagi har bir simvolni sanash va har bir
// simvolning nechta marta qaytarilganini aniqlang.
// Natijalarni ekranga chiqaring.
// Input: "Hello, world!"
// Output: 'H': 1 martta, 'e': 1 martta, 'l': 3 martta, 'o': 2 martta,
// ',': 1 martta, ' ': 1 martta, 'w': 1 martta, 'r': 1 martta,
// 'd': 1 martta, '!': 1 martta
Console.WriteLine();
Console.Write("Matn kiriting: ");
string text = Console.ReadLine();
char[] characters = new char[text.Length];
int[] counts = new int[text.Length];
int index = 0;
foreach (char c in text)
{
    bool found = false;

    for(int i = 0; i < index; i++)
    {
        if(characters[i] == c)
        {
            counts[i]++;
            found = true;
            break;
        }
    }
    if(!found)
    {
        characters[index] = c;
        counts[index] = 1;
        index++;
    }
}
for(int i = 0; i < index; i++)
{
    Console.WriteLine($"'{characters[i]}': {counts[i]} martta");
}
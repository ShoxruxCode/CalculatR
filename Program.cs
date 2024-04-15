using System;

// Basics.Tanlash bo’limi uchun 1-amaliy vazifa
// 1-topshiriq
// String ustida amallar
// String tipida (string str) qiymat berilgan. Consoleda int tipidagi qiymat kiriting. Agar
// bu son str ning uzunligidan katta bo’lsa, str ni katta harflarga o’giring, aks holda kichik
// harflarga o’giring.
// Input: x=13, str=”teLefOn”
// Output: “TELEFON”
// ---------------
// Input: x=4, str=”komPyuter”
// Output: “kompyuter”
Console.Write("Biron bir katta va kichik harflardan iborat matn kiriting: ");
string str = Console.ReadLine();
Console.Write("Kiritilgan matnning uzunligidan katta yoki kichik bo'lgan butun son kiriting: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > str.Length)
{
    str = str.ToUpper();
    Console.WriteLine($"Kiritilgan matn katta harflarga o'girildi: {str}");
}
else if(number < str.Length)
{
    str = str.ToLower();
    Console.WriteLine($"Kiritilgan matn kichik harflarga o'girildi: {str}");
}
else if(number == str.Length)
{
    Console.WriteLine("Kiritilgan son va matnning uzunligi teng bo'lganligi uchun kiritilgan matn o'zgarishsiz qoldi");
}
else
{
    Console.WriteLine("Operation is not found!");
}
// 2-topshiriq
// Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
// int x = 15;
// int y = 10;
// string result = (x > y)
//     ? "x is greater than y"
//     : (x < y)
//         ? "x is less than y"
//         : (x == y)
//             ? "x is equal to y"
//             : "x and y are not comparable";
// Console.WriteLine(result);
int x = 15;
int y = 10;
if(x > y)
{
    Console.WriteLine("x is greater than y");
}
    else if(x < y)
    {
        Console.WriteLine("x is less than y");
    }
        else if(x == y)
        {
            Console.WriteLine("x is equal to y");
        }
            else
            {
                Console.WriteLine("x and y are not comparable");
            }
// 3-topshiriq
// Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib, natijani ekranga
// chiqaradigan dastur tuzing. Switch expression dan foydalaning!
Console.Write("Biron bir hafta kunini kiriting (so'zning bosh harfi katta harfda yozilsin): ");
string dayInWeek = Console.ReadLine();
string result = dayInWeek switch
{
    "Dushanba"   => "Monday",
    "Seshanba"   => "Tuesday",
    "Chorshanba" => "Wednesday",
    "Payshanba"  => "Thursday",
    "Juma"       => "Friday",
    "Shanba"     => "Saturday",
    "Yakshanba"  => "Sunday",
    _ => "Bunday hafta kuni mavjud emas!"
};
Console.WriteLine(result);
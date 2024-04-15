using System;

// Basics.Tanlash bo'limi uchun 2-amaliy vazifa
// 1-topshiriq
// Vaqt kalkulyatori:
// Kirish sifatida daqiqalar sonini oladigan va uni soat:daqiqa formatida chiqaradigan dastur
// yozing. Misol uchun, agar foydalanuvchi 135 daqiqani kiritsa, dastur "2:15" chiqishi kerak.
// Hisoblash uchun arifmetik amallardan foydalaning.
Console.Write("Vatni daqiqa ko'rinishida kiriting (musbat va butun son kiriting): ");
int timeAsMinutes = Convert.ToInt32(Console.ReadLine());
if(timeAsMinutes > 0)
{
    int hours = timeAsMinutes / 60;
    int minutes = timeAsMinutes % 60;
    Console.WriteLine($"{hours} : {minutes}");
    Console.WriteLine($"Ya'ni {hours} soat {minutes} daqiqa");
}
else
{
    Console.WriteLine("Siz manfiy son kiritdingiz");
}
// 2-topshiriq
// Yosh toifasini aniqlash:
// Foydalanuvchining yoshini so'ragan va uning yosh toifasini aniqlaydigan dastur yarating:
// "bola" (0-12 yosh), "o'smir" (13-19 yosh), "kattalar" (20-59 yosh) yoki " katta” (60 yosh) va
// undan katta). Bu vazifa uchun if-else iboralaridan foydalaning.
Console.Write("Yoshingizni kiriting (qiymat butun son ko'rinishida bo'lsin): ");
int ageUser = Convert.ToInt32(Console.ReadLine());
if(ageUser > 0 && ageUser <= 12)
{
    Console.WriteLine("bola");
}
else if(ageUser >= 13 && ageUser <= 19)
{
    Console.WriteLine("o'smir");
}
else if(ageUser >= 20 && ageUser <= 59)
{
    Console.WriteLine("kattalar");
}
else if(ageUser == 60)
{
    Console.WriteLine("katta");
}
else if(ageUser > 60)
{
    Console.WriteLine("undan katta");
}
else
{
    Console.WriteLine("Value is not found");
}
// 3-topshiriq
// O'rtacha ballni hisoblash:
// Foydalanuvchidan uchta fan bo'yicha (0 dan 100 gacha) baholarni so'raydigan va ularning
// o'rtacha ballini hisoblaydigan dastur yozing. Keyin dastur natija haqida xabarni ko'rsatadi:
// "A'lo" (o'rtacha ball 80 dan 100 gacha), "Yaxshi" (o'rtacha ball 60 dan 79 gacha), "Qoniqarli"
// (o'rtacha ball 40 dan 59 gacha) yoki "Qoniqarsiz" ( o'rtacha ball 40 dan kam). Shartlarni
// tekshirish uchun ternary operatoridan foydalaning.
Console.WriteLine("uchta fan bo'yicha o'rtacha ballini hisoblaydigan dastur (Baholarni butun son ko'rinishida kiriting)");
Console.Write("Birinchi faningizdan olgan bahoingizni kiriting (0 dan 100 gacha): ");
int firstSubject = Convert.ToInt32(Console.ReadLine());
Console.Write("Ikkinchi faningizdan olgan bahoingizni kiriting (0 dan 100 gacha): ");
int secondSubject = Convert.ToInt32(Console.ReadLine());
Console.Write("Uchinchi faningizdan olgan bahoingizni kiriting (0 dan 100 gacha): ");
int thirdSubject = Convert.ToInt32(Console.ReadLine());
int averageScore = (firstSubject + secondSubject + thirdSubject) / 3;
string categoryAverageScore = (averageScore >=80 && averageScore <=100)
    ? "A'lo" 
    : (averageScore >=60 && averageScore <=79)
        ? "Yaxshi"
        : (averageScore >=40 && averageScore <=59)
            ? "Qoniqarli"
            : (averageScore < 40)
                ? "Qoniqarsiz"
                : "averageScore is not comparable";
Console.WriteLine(categoryAverageScore);
Console.WriteLine($"Sizning o'rtacha ballingiz: {averageScore} va bu {categoryAverageScore} natija");
// 4-topshiriq
// "Raqamni toping" o'yini:
// 1 dan 100 gacha bo'lgan tasodifiy sonni yaratadigan dastur yarating va keyin
// foydalanuvchidan bu raqamni taxmin qilishni so'raydi. Dastur sirli raqam foydalanuvchi
// kiritgan raqamdan katta yoki kichik ekanligi haqida maslahatlar berishi kerak. Ternary
// operatoridan va Random dan foydalaning
Random random = new Random();
int randomNumber = random.Next(1, 101);
Console.Write("Random sonni tahmin qilib ko'ring (1 dan 100 gacha bo'lgan tasodifiy butun son): ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
string guessNumber = (randomNumber > inputNumber)
    ? "Tasodifiy son kiritilgan sondan katta"
    : (randomNumber < inputNumber)
        ? "Tasodifiy son kiritilgan sondan kichik"
        : (randomNumber == inputNumber)
            ? "Tasodifiy son kiritilgan songa teng"
            : "Random number and input number are not comparable";
Console.WriteLine(guessNumber);
Console.WriteLine($"Tasodifiy son o'zgarib turadi va uning hozirgi qiymati: {randomNumber}");
// Agar tasodifiy sonlarni double toifasida berish kerak bo'lsa unda shu formulani ishlatish kerak :
// Random random = new Random();
// double minimumQiymat  = 1;
// double maksimumQiymat = 100;
// double randomDouble = random.NextDouble() * (maksimumQiymat - minimumQiymat) + minimumQiymat;
// foydalanuvchidan ham double toifali son kiritilishini talab qilinadi.
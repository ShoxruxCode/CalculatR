using System;

// Console.Write("Enter first number: ");
// string asFirstNumber = Console.ReadLine();
// int firstNumber = Convert.ToInt32(asFirstNumber);
// Console.Write("Enter second number: ");
// string asSecondNumber = Console.ReadLine();
// int secondNumber = Convert.ToInt32(asSecondNumber);
// Console.Write("Enter operations (+, -, *, /, %) : ");
// string operations = Console.ReadLine();
// if(firstNumber > secondNumber)
// {
//     Console.WriteLine("first number is bigger than second number");
// } else if(firstNumber == secondNumber)
// {
//     Console.WriteLine("first number is equal to second number");
// } else 
// {
//     Console.WriteLine("first number is lower than second number");
// }
// string message =
//     firstNumber >= secondNumber 
//         ? "first number is bigger than or equal to second number" 
//         : "first number is lower than second number";
// Console.WriteLine(message);
// switch(operations)
// {
//     case "+" :
//         Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
//         break;
//     case "-" :
//         Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
//         break;
//     case "*" :
//         Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
//         break;
//     case "/" :
//         Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
//         break;
//     case "%" :
//         Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
//         break;
//     default :
//         Console.WriteLine("Operation not found");
//         break;
// }
// string result = operations switch
// {
//     "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
//     "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
//     "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
//     "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
//     "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
//     _ => "Operation not found"
// };
// Console.WriteLine(result);

// Basic.Ketma-ketlik bo'limi uchun 3-amaliy vazifa
// 1-topshiriq
// Tub sonlar: Foydalanuvchidan kiritilgan sonning tub son ekanligini tekshiruvchi
// dastur tuzing. Agar kiritilgan son tub bo'lsa, "Tub" degan xabar chiqaring, aks holda
// "Tub emas" degan xabar chiqaring.
// Input = 7; 
// Output = “Tub”
Console.Write("Butun son kiriting: ");
int tubSonUchun = Convert.ToInt32(Console.ReadLine());
if (tubgaTekshirish(tubSonUchun))
{
    Console.WriteLine("Tub");
}
else {
    Console.WriteLine("Tub emas");
}
bool tubgaTekshirish (int tubSonUchun)
{
    if(tubSonUchun <= 1)
        return false;
    if(tubSonUchun == 2)
        return true;
    if(tubSonUchun % 2 == 0)
        return false;
    for(int i = 3; i < tubSonUchun; i++){
        if(tubSonUchun % i == 0)
            return false;
    }
    return true;
}
// 2-topshiriq
// Bo'luvchisiz sonlar: Foydalanuvchidan son qabul qilib, shu sonni 2 dan boshlab 10 
// gacha bo'lgan bo'luvchilarini hisoblovchi dastur yozing. Natijani ekranga chiqaring. 
// Input = 20; 
// Output = "Bo'luvchilari: 2, 4, 5, 10"
Console.Write("2 dan katta son kiriting va 2 dan 10 gacha bo'lgan oraliqdagi bo'luvchilarini toping: ");
int boluvchiSonUchun = Convert.ToInt32(Console.ReadLine());
for(int i = 2; i <= 10; i++)
{
    if(boluvchiSonUchun % i == 0)
    {
        Console.Write($"Bo'luvchilari: {i}\n");
    }
}
// 3-topshiriq
// Daraja hisoblash: Foydalanuvchidan son va uning darajasini qabul qilib, berilgan sonni berilgan
// darajaga ko'taradigan dastur tuzing. Daraja musbat butun son bo'lishi
// kerak.
// Input = 3, 4;
// Output = 81
Console.Write("Darajaga oshirmoqchi bo'lgan soninggizni kiriting: ");
int butunSon = Convert.ToInt32(Console.ReadLine());
Console.Write("Sonning darajasini kiriting (Daraja musbat butun son bo'lishi kerak): ");
int daraja = Convert.ToInt32(Console.ReadLine());
int darajaHisoblash = (int)Math.Pow(butunSon, daraja);
if(daraja > 0){
    Console.Write($"Darajaga oshirildi: {darajaHisoblash}\n");
}
else
{
    Console.WriteLine("Bu sonning darajasi manfiy\n");
}
// 4-topshiriq
// Harajatlar to'plamini hisoblash: Foydalanuvchidan bir nechta to'plam miqdorlar
// kiritilgan holda, ularni qo'shib yig'indisini hisoblovchi dastur yozing va natijani ekranga
// chiqaring. 
// Input = [150, 230, 80, 120]; 
// Output = 580
Console.Write("To'plam massivini uzunligini kiriting: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int[length];
Console.WriteLine("To'plam massiv elementlarini kiriting: ");
for(int i = 0; i < length; i++)
{
    Console.Write($"array[{i+1}]=");
    array[i] = int.Parse(Console.ReadLine());
}
for(int i = 0; i < length; i++)
{
    Console.WriteLine($"Element {i+1}: {array[i]}");
}
int sum = 0;
for(int i = 0; i < length; i++)
{
    sum += array[i];
}
Console.WriteLine($"To'plamdagi sonlar yig'indisi: {sum}");
// 5-topshiriq
// Armstrong sonlar: Foydalanuvchidan son qabul qilib, shu sonni Armstrong son
// ekanligini aniqlang. Armstrong son, raqamlarining darajasiga mos keladigan
// sonlardir. Masalan: 
// Input = 153; 
// Output = "153 Armstrong son" 
// 153 raqamining raqamlarini darajaga olib, o'lchamalarga ko'paytirib qo'ygan holda,
// 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153 bo'ladi. Bu sababli, 153 raqami Armstrong son
//hisoblanadi.
Console.Write("Armstrong son kiriting: ");
int number = Convert.ToInt32(Console.ReadLine());
if(ArmstrongGaTekshirish(number))
{
    Console.WriteLine($"{number} Armstrong son");
}
else
{
    Console.WriteLine($"{number} Armstrong son emas");
}
bool ArmstrongGaTekshirish(int number)
{
    int sonArmstrong = number;
    int sum = 0;
    int sonningNechiXonaligi = SonningNechiXonaligi(number);
    while (number > 0)
    {
        int sonHonasi = number % 10;
        sum+=(int)Math.Pow(sonHonasi, sonningNechiXonaligi);
        number /= 10;
    }
    return sum == sonArmstrong;
}
    int SonningNechiXonaligi (int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

// 6-topshiriq
// Sifatli bo'luvchilar: Foydalanuvchidan son qabul qilib, shu sonni nechta sifatli
// bo'luvchilarini hisoblang. Sifatli bo'luvchilar, faqat bittadan o'zidan keyincha bo'lan
// sonlar hisoblanadi. Masalan: 
// Input = 20; 
// Output = 4 
// 20 raqamining sifatli bo'luvchilari 1, 2, 4, va 5 sonlari hisoblanadi.
Console.Write("Son kiriting va sifatli bo'luvchilarini bilib oling: ");
int sifatliBoluvchi = Convert.ToInt32(Console.ReadLine());
int counts = 0;
for(int i = 1; i < sifatliBoluvchi; i++)
{
    if(sifatliBoluvchi % i == 0 && sifatliBoluvchi / i != 2)
    {
        counts++;
        Console.WriteLine($"Kiritilgan sonning bo'luvchilari: {i}");
    }
}
Console.WriteLine($"{sifatliBoluvchi} soninig sifatli bo'luvchilari soni: {counts}");
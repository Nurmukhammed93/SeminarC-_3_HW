// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine()!);

if (10000 <= num && num < 100000)
{
    int dig1 = num / 10000;
    int dig2 = num / 1000 % 10;
    int dig4 = num / 10 % 10;
    int dig5 = num % 10;

    if (dig1 == dig5 && dig4 == dig2)
    {
        Console.WriteLine("Да, палиндром.");
    }
    else
    {
        Console.WriteLine("Не палиндром.");
    }
}
else 
{
    Console.WriteLine("Неправильный ввод");
}
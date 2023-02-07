// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int a1= num / 10000,  a2 = num % 10, b1 = (num / 1000) % 10, b2 = (num / 10) % 10;

if (a1 == a2 && b1 == b2)
{
    Console.WriteLine($"Да"!);
}
else
{
    Console.WriteLine($"Нет"!);
}
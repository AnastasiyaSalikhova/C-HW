// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int K = N % 10;
int Sum = K;
while (N != 0)
{
N /= 10;
K = N % 10;
Sum = Sum + K;
}
Console.WriteLine($"{Sum}"!);
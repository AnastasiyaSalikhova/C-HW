// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

int Powe(int A, int B)
{
int result = 1;
for (int i = 0; i < B; i++)
{
result *= A;
}
return result;
}

Console.Write($"Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{a} в степени {b} = {Powe(a, b)}");
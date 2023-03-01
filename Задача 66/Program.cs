// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int Sum(int M, int N)
{
    if (M == N) return M;
    return Sum(M + 1, N) + M;
}

Console.Write($"Задайте значение M: "!);
int M = int.Parse(Console.ReadLine()!);

Console.Write($"Задайте значение N: "!);
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Sum(M, N));
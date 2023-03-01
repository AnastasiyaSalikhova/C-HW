// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write($"Введите неотрицательное число m: "!);
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите неотрицательное число n: "!);
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A(m,n) = {Akkerman(m, n)}");
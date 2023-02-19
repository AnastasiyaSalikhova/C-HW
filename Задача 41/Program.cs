//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
int[] Result = new int[size];

for (int i = 0; i < size; i++)
{
Result[i] = new Random().Next(MinValue, MaxValue + 1);
}
return Result;
}
int GetPozitiveElements(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

Console.WriteLine("Введите числа: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size, -99, 999);
Console.Write(String.Join ("," , array));
Console.Write(" -> ");
Console.Write(String.Join ("," , GetPozitiveElements(array)));
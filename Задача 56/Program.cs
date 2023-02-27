//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] GetArray2D(int rows, int columns, int minValue, int maxValue)
{
    int[,] array2D = new int[rows, columns];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

void PrintArray(int[,] array2D)

{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for(int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void GetRowMinSumElements(int[,] inArray)
{
    int min = 0;
    int minRow = 1;
    int sum;
    bool started = false;

    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        sum = 0;
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if(!started || sum < min)
        {
            started = true;
            min = sum;
            minRow = i + 1;
        }
    }
    Console.WriteLine($"{minRow} строка ");
}

Console.Write("Введите колличество рядов: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] myArray = GetArray2D(rows, columns, 0, 10);
Console.WriteLine();
PrintArray(myArray);
GetRowMinSumElements(myArray);

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if(matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Матрицы невозможно перемножить. ");
        return matrixC;
    }
    for(int i = 0; i < matrixC.GetLength(0); i++)
    {
        for(int j = 0; j < matrixC.GetLength(1); j++)
        {
            for(int k = 0; k < matrixC.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.Write("Введите матрицу A через запятую: ");
int[] sizeA = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int[,] matrixA = GetMatrix(sizeA[0], sizeA[1], 0, 10);

Console.Write("Введите матрицу B через запятую: ");
int[] sizeB = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int[,] matrixB = GetMatrix(sizeB[0], sizeB[1], 0, 10);

PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
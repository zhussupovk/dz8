// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] matrix1 = GetArray(2, 2);
int[,] matrix2 = GetArray(2, 2);
PrintArray(matrix1);
PrintArray(matrix2);
PrintArray(MultArr(matrix1, matrix2));
int[,] MultArr(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int l = 0; l < matrix2.GetLength(0); l++)
            {
                result[i,j] += matrix1[i,l] * matrix2[l,j];
            }
        }
    }
    return result;
}
int[,] GetArray(int row, int col, int maxValue = 5, int minValue = 1)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


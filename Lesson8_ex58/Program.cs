// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите размерность прямоугольных матриц: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;
int[,] firstArray = new int[rows, columns];
int[,] secondArray = new int[rows, columns];

Console.WriteLine("Первая матрица: ");
FillArray(firstArray);
PrintArray(firstArray);

Console.WriteLine("Вторая матрица: ");
FillArray(secondArray);
PrintArray(secondArray);

Console.WriteLine("Произведение матриц: ");
matrixMultiplication(firstArray, secondArray);

void FillArray(int[,] argyment)
{
    for (int i = 0; i < argyment.GetLength(0); i++)
    {
        for (int j = 0; j < argyment.GetLength(1); j++)
        {
            argyment[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] argyment)
{
    for (int i = 0; i < argyment.GetLength(0); i++)
    {
        for (int j = 0; j < argyment.GetLength(1); j++)
        {
            Console.Write($"{argyment[i, j],4}");
        }
        Console.WriteLine();
    }
}

void matrixMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] multiplyArray = new int[rows, columns];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            multiplyArray[i, j] = sum;
            Console.Write($"{multiplyArray[i, j],4} ");

        }
        Console.WriteLine();
    }
}

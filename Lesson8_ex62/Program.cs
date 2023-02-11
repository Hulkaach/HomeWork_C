// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

Console.WriteLine("Матрица: ");
FillArray(array);
PrintArray(array);

void FillArray(int[,] arr)
{
    int n = arr.GetLength(0); // Матрица квадратная n=m=4, можно использовать одно значения для обозначения края как строки так и столбца (возмем n)

    int sum = 1;
    for (int j = 0; j < n; j++)
    {
        arr[0, j] = sum;
        sum++;
    }
    for (int i = 1; i < n; i++)
    {
        arr[i, n - 1] = sum;
        sum++;
    }
    for (int k = 2; k >= 0; k--)
    {
        arr[n - 1, k] = sum;
        sum++;
    }
    for (int m = 2; m > 0; m--)
    {
        arr[m, 0] = sum;
        sum++;
    }
    for (int l = 1; l < n - 1; l++)
    {
        arr[1, l] = sum;
        sum++;
    }
    for (int v = 2; v < n - 1; v++)
    {
        arr[n - 2, v] = sum;
        sum++;
    }
    for (int r = 1; r < n - 2; r++)
    {
        arr[n - 2, r] = sum;
        sum++;
    }
}

void PrintArray(int[,] argyment)
{
    for (int i = 0; i < argyment.GetLength(0); i++)
    {
        for (int j = 0; j < argyment.GetLength(1); j++)
        {
            Console.Write($"{argyment[i, j],4} ");
        }
        Console.WriteLine();
    }
}
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите размерность массива");
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine("Упорядоченный массив:");
FSelectArray(array);
PrintArray(array);

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

void FSelectArray(int[,] argument2)
{
    for (int i = 0; i < argument2.GetLength(0); i++)
    {
        for (int j = 0; j < argument2.GetLength(1); j++)
        {
            for (int k = 0; k < argument2.GetLength(1) - 1; k++)
            {
                if (argument2[i, k + 1] > argument2[i, k])
                {
                    int tempmax = argument2[i, k + 1];
                    argument2[i, k + 1] = argument2[i, k];
                    argument2[i, k] = tempmax;
                }
            }
        }
    }
}

 
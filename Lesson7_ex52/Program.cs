// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите размерность массива");
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
FMidleColumns(array);

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

void FMidleColumns(int[,] argument2)
{

    for (int j = 0; j < argument2.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < argument2.GetLength(0); i++)
        {
            sum += argument2[i, j];
        }
        Console.Write($"{Math.Round(sum/rows, 2),3} ");
    }
}



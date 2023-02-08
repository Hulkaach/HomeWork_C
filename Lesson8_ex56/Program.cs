// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите размерность прямоугольного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
FindSumRows(array);

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

void FindSumRows(int[,] argument2)
{
    int minrow = argument2[0, 0];
    int findrow = 0;
    for (int j = 1; j < argument2.GetLength(1); j++)
    {
        minrow += argument2[0, j];
    }

    for (int i = 1; i < argument2.GetLength(0); i++)
    {
        int findsumrows = 0;
        for (int j = 0; j < argument2.GetLength(1); j++)
        {
            findsumrows += argument2[i, j];
        }
        if (findsumrows < minrow)
        {
            minrow = findsumrows;
            findrow = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов -> {findrow} (Отсчет от 0 (нуля) ");
}



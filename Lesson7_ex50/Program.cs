// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

Console.WriteLine("Необходимо задать размерность массива");
Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
// FillArray(rows, columns); // Вызываем метод заполнения и печати двумерного массива передавая ему количество строк и столбцов

Console.Write("Введите позицию искомого элемента массива (Строка №): ");
int findrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию искомого элемента массива (Столбец №): ");
int findcolumns = Convert.ToInt32(Console.ReadLine());

int[,] findarray = FillArray(rows, columns); // Присваеваем переменной результат работы метода заполнения двумерного массива
int found = FindElement(findarray, findrows, findcolumns); // Присваеваем переменной результат работы метода поиска элемента в массиве
if (found ==-10) // Проверка есть ли в массиве. Принято -10, т.к. массив рандомный от -9 до 9.
{Console.WriteLine("-> Такого числа в массиве нет");}
else 
{Console.WriteLine($"-> {found}");}

int[,] FillArray(int n, int m) //Описываем метод заполнения и печати двумерного массива рандомными целыми числами
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();

    }
    return array;
}

int FindElement(int[,] argument, int fRow, int fColumn)
{
    int foundElement = -10;
    for (int i = 0; i < argument.GetLength(0); i++)
    {
        for (int j = 0; j < argument.GetLength(1); j++)
        {
            if (i == fRow && j == fColumn)
                foundElement = argument[i, j];
        }
    }
    return foundElement;
}

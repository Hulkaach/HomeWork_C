// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите размерность трехмерной матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;
int depth = rows;
int[,,] array = new int[rows, columns, depth];

Console.WriteLine("Матрица: ");
FillArray(array);
PrintArray(array);

void FillArray(int[,,] argyment)
{
    int temp = 10;
    for (int i = 0; i < argyment.GetLength(0); i++)
    {
        for (int j = 0; j < argyment.GetLength(1); j++)
        {
            for (int k = 0; k < argyment.GetLength(2); k++)
            {

                argyment[i, j, k] = temp;
                temp++;
            }
        }
    }
}

void PrintArray(int[,,] argyment)
{
    for (int i = 0; i < argyment.GetLength(0); i++)
    {
        for (int j = 0; j < argyment.GetLength(1); j++)
        {
            for (int k = 0; k < argyment.GetLength(2); k++)
            {
                Console.Write($"{argyment[i, j, k],4} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}
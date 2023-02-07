// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Необходимо задать размерность массива");
Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, columns];
void FillArray(double[,] argyment)
{
    for (int i = 0; i < argyment.GetLength(0); i++)
    {
        for (int j = 0; j < argyment.GetLength(1); j++)
        {
            int select = new Random().Next(-10,11);
            double rnd = new Random().NextDouble();
            double random = select*rnd;
            argyment[i, j] = Math.Round(random,1);
            Console.Write($"{argyment[i, j],4} ");
        }
        Console.WriteLine();
    }
}
FillArray(array);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Массив из N элементов из заданного диапозона
Console.WriteLine("Введите количество элементов массива :");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите нижнюю границу диапозона значений элементов массива :");
int min_arr = int.Parse(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу диапозона значений элементов массива :");
int max_arr = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("[");
int[] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine("]");
void FillArray(int[] argument1)
{
    int length = argument1.Length;
    int index =0;
    while (index < length)
    {
        argument1[index] = new Random().Next(min_arr, max_arr+1);
        index ++;
    }
}

void PrintArray(int [] argument2)
{
    int count = argument2.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(argument2[position] + " ");
        position ++;
    }
}

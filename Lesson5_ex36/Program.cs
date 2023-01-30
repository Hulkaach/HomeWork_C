// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void FillArray()
{
    int rand = new Random().Next(1, 10);
    int[] array = new int[rand];
    int count = 0;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
        if (i % 2 == 1)
            count = count + array[i];
    }
    Console.Write("\b] -> " + count);
}
FillArray();

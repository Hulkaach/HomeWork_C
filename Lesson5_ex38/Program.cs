// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int rand = new Random().Next(1, 10);
int[] array = new int[rand];
void FillArray()
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }

    Console.Write($"\b] -> ");

}
FillArray();

int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
Console.Write(max - min);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray ()
{
    int rand = new Random().Next(4,7);
    int [] array = new int [rand];
    int count = 0;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(100,1000);
        Console.Write($"{array[i]} ");
        if (array[i]%2==0)
        count ++;
    }
    Console.Write("\b] -> "+count);
}
FillArray();
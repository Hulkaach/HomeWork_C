// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите какое количество чисел необходимо ? ");

int quantityNumbers = Convert.ToInt32(Console.ReadLine());

void InputNumbres(int argyment)
{
    int[] array = new int[argyment];
    int countNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива ");
        int number = Convert.ToInt32(Console.ReadLine()); ;
        array[i] = number;
        if (array[i] > 0) countNumbers++;
    }
    Console.WriteLine($"-> Количество введенных чисел больше 0 равно {countNumbers}"); 
}
InputNumbres(quantityNumbers);
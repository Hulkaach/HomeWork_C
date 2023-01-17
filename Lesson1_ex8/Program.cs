// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введи число от 2 до любого числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int start = 2;

    while (num1 > 1)
    {
        Console.Write(start + " ");
        num1 -= 2;
        start += 2;
    }

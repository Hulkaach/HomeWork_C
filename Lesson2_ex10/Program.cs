// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = (num1 / 100);
int num3 = (num1 % 10);
int num4 = (num1 - num2 * 100 - num3) / 10;
Console.WriteLine("Вторая цифра числа " + num1 + " равна " + num4);

﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введи число ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 1)
{
    Console.Write("Введенное число явлеятся нечетным");
}
else
{
    Console.Write("Введенное число явлеятся четным");
}

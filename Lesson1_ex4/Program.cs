// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введи первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > num1)
{
    max = num2;
}
else if (num3 > num1)
{
    max = num3;
}
if (num2 > num3)
{
    max = num2;
}
else if (num3 > num2)
{
    max = num3;
}
Console.Write("max = " + max);

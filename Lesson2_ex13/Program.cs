// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введи число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = (num1 % 10);
int num3 = num1;
int num4 = 1;

if (num1 < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num1 > 100 && num1 < 1000)
{
    Console.WriteLine("Третья цифра числа " + num1 + " равна " + num2);
}
else
{
    while (num3 > 999)
    {
        num3 = num3 / 10;
    }
    num4 = num3 % 10;
    Console.WriteLine("Третья цифра числа " + num1 + " равна " + num4);
}

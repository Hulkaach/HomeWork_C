// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите минимальное значение - M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение - N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(m, n));

int SumNumbers(int argument1, int argument2)
{
    if (argument1 == argument2) return argument2;
    return (argument1 + SumNumbers(argument1 + 1, argument2));
}

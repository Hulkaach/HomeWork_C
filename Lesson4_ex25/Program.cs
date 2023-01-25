// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число А: ");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int b1 = int.Parse(Console.ReadLine());
int a2 = a1;
int a3 = 0;
for (int i = 1; i < b1; i++)
{
    a3 = a2 * a1;
    a2 = a3;
}
Console.WriteLine(a1 + " в степени " + b1 + " равно : " + a3);
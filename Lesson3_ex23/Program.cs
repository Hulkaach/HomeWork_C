// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("ведите число N: ");
int n = int.Parse(Console.ReadLine());
int pow3 = 1;
while (pow3 <= n)
{
    Console.Write(" " + (Math.Pow(pow3,3)));
    pow3 ++;
}  

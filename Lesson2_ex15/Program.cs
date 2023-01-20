// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
int Function(int arg1)
{
    int result = 0;
    if (arg1 == 1) result = 1;
    else if (arg1 == 2) result = 1;
    else if (arg1 == 3) result = 1;
    else if (arg1 == 4) result = 1;
    else if (arg1 == 5) result = 1;
    else if (arg1 == 6) result = 2;
    else if (arg1 == 7) result = 2;
    return result;
}

Console.WriteLine("Введи число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int result1 = Function(num1);
if (num1 < 1 || num1 > 7)
{
    Console.WriteLine("Введенное число не соответствует дню недели");
}
else if (result1 == 1)
{
        Console.WriteLine("Введенное число не соответствует выходному дню недели");
}
else if (result1 == 2) 
{   Console.WriteLine("Введенное число соответствует выходному дню недели");
    // string result1 = Function(num1);
}


 

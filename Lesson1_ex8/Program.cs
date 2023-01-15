// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введи число от 2 до любого числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int start = 2;

// if (num1 > 0)
// {
    while (num1 > 1)
    {
        Console.Write(start + " ");
        num1 -= 2;
        start += 2;
    }
// }
// else
// {
//     start = start * -1;
//     while (num1 < 1)
//     {
//         Console.Write(start + " ");
//         start -= 2;
//         num1 += 2;
//     }
    
// }

// if (num1 < 0)
// {
//     num1 = num1 * -1;
// }
// int num2 = num1 % 2;
// Console.WriteLine(num2);
// if (num2 > 0)
// {
//     while (num1 > 1)
//     {
//         Console.Write(start + " ");
//         num1 -= 2;
//         start += 2;
//     }
// }
// else
// {
//     while (num1 < 1)
//     {
//         if (num1 % 2 == 0)
//         {
//             Console.Write(num1 + " ");
//         }

//         num1 += 1;
//     }
// }
// if (num2 > 0)
// {
//     while (num1 > 1)
//     {
//         if (num1 % 2 == 0)
//         {
//             Console.Write(num1 + " ");
//         }

//         num1 -= 1;
//     }
// }
// else 
// {
//     while (num1 < 1)
//     {
//         if (num1 % 2 == 0)
//         {
//             Console.Write(num1 + " ");
//         }

//         num1 += 1;
//     } 
// }
//Seminar - 1

// Задача 2: -------------------------------------------------------------------------------------------
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Enter the first number: ");
// int numbFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second number: ");
// int numbSecond = Convert.ToInt32(Console.ReadLine());

// if (numbFirst > numbSecond)
//     Console.WriteLine($"Number {numbFirst} > {numbSecond}");
// else if (numbFirst < numbSecond)
//     Console.WriteLine($"Number {numbFirst} < {numbSecond}");
// else
//     Console.WriteLine($"Number {numbFirst} = {numbSecond}");

// Задача 4: ------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Enter the first number ");
// int numbFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second number ");
// int numbSecond = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the third number ");
// int numbThird = Convert.ToInt32(Console.ReadLine());

// if ((numbFirst > numbSecond) && (numbFirst > numbThird))
//     Console.WriteLine("max = " + numbFirst);
// else if ((numbSecond > numbFirst) && (numbSecond > numbThird))
// { Console.WriteLine("max = " + numbFirst); }
// else if (numbThird > numbFirst && numbThird > numbSecond)
// { Console.WriteLine("max = " + numbThird); }
// else
//     Console.WriteLine("Another case");


// Задача 6: ------------------------------------------------------------------------------------------
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Enter a number: ");
// int numb = Convert.ToInt32(Console.ReadLine());

// if ((numb % 2) == 0)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     Console.WriteLine("Number " + numb + " even");
// }
// else
// {
//     Console.BackgroundColor = ConsoleColor.Red;
//     Console.WriteLine("Number " + numb + " odd");
// }

// Задача 8: ------------------------------------------------------------------------------------------
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// int i = 1;

// Console.Write("Enter a number: ");
// int numb = Convert.ToInt32(Console.ReadLine());


// if (numb <= 0)
// {
//     Console.BackgroundColor = ConsoleColor.Red;
//     Console.Write("Enter a number > 0 :");
//     numb = Convert.ToInt32(Console.ReadLine());
// }
// if (numb > 0)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     while (i <= numb)
//     {
//         if ((i % 2) == 0)
//             Console.Write(i + " ");
//         i++;
//     }
// }

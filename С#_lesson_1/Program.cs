﻿// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3
// Console.WriteLine("Выводим два числа и какое больше.");
// Console.Write("Введите первое число: ");
// int numA = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numB = int.Parse(Console.ReadLine());
// if (numA > numB)
// {
//     Console.WriteLine($"a = {numA}; b = {numB} -> max = {numA}");
// }
// else if (numA == numB)
// {
//     Console.WriteLine($"{numA} и {numB} равны");
// }
// else
// {
//     Console.WriteLine($"a = {numA}; b = {numB} -> max = {numB}");
// }



// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22
// Console.WriteLine("Выводим три числа и какое больше.");
// Console.Write("Введите первое число: ");
// int numA = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numB = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int numC = int.Parse(Console.ReadLine());
// if ((numA >= numB) & (numA >= numC))
// {
//     Console.WriteLine($"{numA}, {numB}, {numC} -> {numA}");
// }
// else if ((numB >= numA) & (numB >= numC))
// {
//     Console.WriteLine($"{numA}, {numB}, {numC} -> {numB}");
// }
// else if ((numC >= numB) & (numC >= numA))
// {
//     Console.WriteLine($"{numA}, {numB}, {numC} -> {numC}");
// }
// else
// {
//     Console.WriteLine("Введены не правильные данные, попробуй еще раз!!!");
// }



// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет
// Console.WriteLine("Проверяем является ли число чётным.");
// Console.Write("Введите четное число: ");
// int numA = int.Parse(Console.ReadLine());
// int i = 0;
// if (numA % 2 == 0)
// {
//     Console.WriteLine($"{numA} -> да");
// }
// else
// {
//     Console.WriteLine($"{numA} -> нет");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Console.WriteLine("Выводим все чётные числа от 1 до N.");
// Console.Write("Введите N число: ");
// int N = int.Parse(Console.ReadLine());
// int count = 2;
// while (count <= N)
// {
//     Console.WriteLine($"{N} -> {count}");
//     count = count + 2;
// }
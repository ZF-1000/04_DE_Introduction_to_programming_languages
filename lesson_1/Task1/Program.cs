/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

using System;
using static System.Console;

Clear();

Write("Введите число a = ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число b = ");
int b = Convert.ToInt32(ReadLine());

Write("max = ");
if (a > b) Write(a);
else Write(b);
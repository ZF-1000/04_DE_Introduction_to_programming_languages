/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using System;
using static System.Console;

Clear();

Write("Введите число a = ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число b = ");
int b = Convert.ToInt32(ReadLine());
Write("Введите число c = ");
int c = Convert.ToInt32(ReadLine());

Write("max = ");
if ((a > b) & (a > c)) Write(a);
if ((b > a) & (b > c)) Write(b);
if ((c > a) & (c > b)) Write(c);

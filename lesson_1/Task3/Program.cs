/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int a = Convert.ToInt32(ReadLine());

if (a % 2 == 0) Write("да");
else Write("нет");

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int numb = Convert.ToInt32(ReadLine());
Write((numb == 6) || (numb == 7) ? $"{numb} -> да" : $"{numb} -> нет");

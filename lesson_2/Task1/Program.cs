/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

using System;
using static System.Console;

Clear();

Write("Введите трёхзначное число: ");
int numb = Convert.ToInt32(ReadLine());
Write($"{numb} -> {numb / 10 % 10}");

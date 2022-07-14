/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями:
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


using System;
using static System.Console;
Clear();


Write("b1 = ");
double b1 = Convert.ToInt32(ReadLine());
Write("k1 = ");
double k1 = Convert.ToInt32(ReadLine());
Write("b2 = ");
double b2 = Convert.ToInt32(ReadLine());
Write("k2 = ");
double k2 = Convert.ToInt32(ReadLine());


Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({Find_X(b1, k1, b2, k2)}; {Find_Y(b1, k1, Find_X(b1, k1, b2, k2))})");



double Find_X(double b_1, double k_1, double b_2, double k_2)
{
    return ((b_2 - b_1) / (k_1 - k_2));
}


double Find_Y(double b_1, double k_1, double x)
{
    return (k_1 * x + b_1);
}


/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System;
using static System.Console;

Clear();
Write("Введите число A: ");
int A = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int B = Convert.ToInt32(ReadLine());

Write($"{A}, {B} -> {GetPow(A, B)}");


int GetPow(int a, int b)
{
    if (b == 0) return 1;
    int res = 1;
    while (b > 0)
    {
        res *= a;
        b--;
    }
    return res;
}
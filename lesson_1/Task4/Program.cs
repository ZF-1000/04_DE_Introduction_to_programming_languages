/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

using System;
using static System.Console;

Clear();

Write("Введите число N = ");
int N = Convert.ToInt32(ReadLine());
int cnt = 1;
while (cnt <= N)
{
    if (cnt % 2 == 0) 
    {
        Write(cnt);
        if ((cnt != N) & (cnt + 1 != N)) Write(", ");
    }
    cnt++;
}

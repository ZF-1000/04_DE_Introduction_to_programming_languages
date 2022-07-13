/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int numb = Convert.ToInt32(ReadLine());

Write($"{numb} -> {SumOfDig(numb)}");


int SumOfDig(int n)
{
    int res = 0;
    while(n > 0)
    {
        res += n % 10;
        n /= 10;
    }
    return res;
}
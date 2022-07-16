/*
Решить через рекурсию
Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.

M = 1; N = 5. ->120
M = 4; N = 6. -> 120
*/

using System;
using static System.Console;
Clear();

Write("Введите число M: ");
int M = int.Parse(ReadLine());
Write("Введите число N: ");
int N = int.Parse(ReadLine());

WriteLine(GetMultNumbInInterval(M, N));


int GetMultNumbInInterval(int m, int n)
{
    int res = 1;

    if (m == n) return n;
    if (m < n) return res * m * GetMultNumbInInterval(m + 1, n);
    else return res * n * GetMultNumbInInterval(n + 1, m);
}
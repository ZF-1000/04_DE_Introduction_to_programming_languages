/*
Решить через рекурсию
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
*/

using System;
using static System.Console;
Clear();

Write("Введите число M: ");
int M = int.Parse(ReadLine());
Write("Введите число N: ");
int N = int.Parse(ReadLine());

WriteLine(AkkermanFunc(M, N));


int AkkermanFunc(int m, int n)
{
if (m == 0) return n + 1;
else if ((m > 0) && (n == 0)) return AkkermanFunc(m - 1, 1);
else if ((m > 0) && (n > 0)) return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
else return n + 1;
}

﻿/*
** Задача 54.** Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Исходный массив:
1 4 7 2
5 9 2 3
8 4 2 4

Результат:
7 4 2 1
9 5 3 2
8 4 4 2
*/


using System;
using static System.Console;
using System.Linq;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetRandomArray(rows, columns);
WriteLine("Исходный массив: ");
PrintArray(ar);
WriteLine("Результат:");
SortDescRowArray(ar);


void SortDescRowArray(int[,] array)
{
    int[] row = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }
        WriteLine(String.Join(" ", row.OrderByDescending(x => x).ToArray()));
    }
    WriteLine();
}


int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
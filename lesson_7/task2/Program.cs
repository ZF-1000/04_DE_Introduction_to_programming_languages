/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
WriteLine($"m = {rows}, n = {columns}");
int[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);

Write($"Среднее арифметическое каждого столбца: {String.Join("; ", MeanOfEachColumn(ar))}");



double[] MeanOfEachColumn(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        double mean = 0.0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            mean += arr[i, j];
        }
        result[j] = Math.Round(mean / arr.GetLength(0), 1);
    }
    return result;
}


int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(-10, 10);
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
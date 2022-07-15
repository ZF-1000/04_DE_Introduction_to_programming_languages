/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
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
CheckElementInArray(ar);



void CheckElementInArray(int[,] arr)
{
    Write("Введите позицию элемента через пробел: ");
    string[] size = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int r = int.Parse(size[0]);
    int c = int.Parse(size[1]);
    if ((r > arr.GetLength(0)) & (c > arr.GetLength(1)))
    {
        Write($"{r} {c} -> такого числа в массиве нет");
    }
    else Write($"{r} {c} -> {arr[r, c]}");

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
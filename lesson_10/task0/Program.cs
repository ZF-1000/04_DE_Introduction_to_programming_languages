/*
Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
*/

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetRandomArray(rows, columns);
WriteLine("Исходная матрица");
PrintArray(ar);

PrintArray(ModArray(ar));


int[,] ModArray(int[,] arr)
{
    int min_el = arr[0, 0];
    int idx_i = 0;
    int idx_j = 0;
    int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min_el)
            {
                min_el = arr[i, j];
                idx_i = i;
                idx_j = j;
            }
        }
    }
    WriteLine($"Наименьший элемент в матрице: {min_el}");
    WriteLine($"idx_i = {idx_i}");
    WriteLine($"idx_j = {idx_j}");
    WriteLine($"Матрица с удаленной строкой и  столбцом с наименьшим элементом:");


    for (int i = 0; i < idx_i; i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < idx_j) res[i, j] = arr[i, j];
            if (j > idx_j) res[i, j - 1] = arr[i, j];
        }
    }
    
    for (int i = idx_i + 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < idx_j) res[i-1, j] = arr[i, j];
            if (j > idx_j) res[i-1, j - 1] = arr[i, j];
        }
    }

    return res;
}


int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 20);
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
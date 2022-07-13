/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Исходный массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Результат:
1-строка
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
RowWithLessSumm(ar);


void RowWithLessSumm(int[,] array)
{
    int[] res = new int[array.GetLength(0)];
    int[] row = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }
        res[i] = row.Sum(x => x);
    }
    WriteLine($"Суммы по строкам:\n{String.Join(" ", res)}");

    int min_el = res[0];
    int min_idx = 0;
    for (int i = 0; i < res.Length; i++)
    {
        if (res[i] < min_el)
        {
            min_el = res[i];
            min_idx = i;
        }
    }
    Write($"Результат:\n{min_idx + 1} - строка");
    // res = res.OrderBy(x => x).ToArray();
    // WriteLine($"Результат:\n{res[0]}");
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
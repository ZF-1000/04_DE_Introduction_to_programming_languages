/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Массив A:
7 9 3      
1 8 7      
1 6 4

Массив В:
7 4 2      
0 0 6      
2 1 0 

Результат
55 31 68   
21 11 50   
15 8 38
*/


using System;
using static System.Console;
using System.Linq;
Clear();


// Одну матрицу можно умножать на другую только тогда, когда количество столбцов в первой матрице совпадает с количеством строк во второй матрице.
Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] arr1 = GetRandomArray(rows, columns);
WriteLine("Массив A: ");
PrintArray(arr1);
int[,] arr2 = GetRandomArray(columns, rows);
WriteLine("Массив В: ");
PrintArray(arr2);
WriteLine("Результат: ");
PrintArray(MultiplicationMatrix(arr1, arr2));



int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] res = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int[] summ = new int[array2.GetLength(0)];
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                summ[k] = array1[i, k] * array2[k, j];
            }
            res[i, j] = summ.Sum(x => x);
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
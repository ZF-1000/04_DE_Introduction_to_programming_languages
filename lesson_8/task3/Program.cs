/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(0,1,0) 53(0,1,1)
32(1,0,0) 41(1,0,1)
66(1,1,0) 88(1,1,1)
*/


using System;
using static System.Console;
using System.Linq;
Clear();


// Write("Введите размер матрицы через пробел: ");
// string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] sizeS = "2 2 2".Split(' ', StringSplitOptions.RemoveEmptyEntries);
int planes = int.Parse(sizeS[0]);
int rows = int.Parse(sizeS[1]);
int columns = int.Parse(sizeS[2]);
int[,,] arr1 = GetRandom3DArray(planes, rows, columns);
Print3DArray(arr1);



bool CheckElemnetInArray(int[,,] array, int numb, int ii, int jj, int kk)
{
    bool flag = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (((i == ii) & (j == jj) & (k == kk))) continue;
                if (array[i, j, k] == numb) return flag;
            }
        }
    }
    flag = false;
    return flag;
}


int[,,] GetRandom3DArray(int plane, int row, int column)
{
    int[,,] result = new int[plane, row, column];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                if (i == 0 & j ==0 & k == 0)
                {
                    // result[i, j, k] = new Random().Next(10, 18);
                    result[i, j, k] = new Random().Next(10, 100);
                }
                else 
                {
                    // result[i, j, k] = new Random().Next(10, 18);
                    result[i, j, k] = new Random().Next(10, 100);
                    while (CheckElemnetInArray(result, result[i, j, k], i, j, k))
                    {
                        // result[i, j, k] = new Random().Next(10, 18);
                        result[i, j, k] = new Random().Next(10, 100);
                    }
                }
            }
        }
    }
    return result;
}


void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            WriteLine();
        }
    }
}
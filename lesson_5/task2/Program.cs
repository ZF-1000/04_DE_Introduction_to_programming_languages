/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76
*/

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(10, 0, 100);
int[] sort_arr = SortArray(array);
WriteLine($"[{String.Join(",", array)}] -> [{String.Join("," , sort_arr)}]");
WriteLine($"{sort_arr[sort_arr.Length - 1]} - {sort_arr[0]} = {GetDiffMaxMin(sort_arr)}");



int GetDiffMaxMin(int[] arr)
{
    int diff = 0;
    diff = arr[arr.Length - 1] - arr[0];
    return diff;
}


int[] SortArray(int[] arr)
{
    int buf = 0;
    for (int i = 0; i < arr.Length - 2; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                buf = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = buf;
            }
        }
    }
    return arr;
}


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
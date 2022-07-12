/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(4, 100, 1000);
WriteLine($"[{String.Join(",", array)}] -> {GetCntEvenNumb(array)}");


int GetCntEvenNumb(int[] array)
{
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        cnt += array[i] % 2 == 0 ? 1 : 0;
    }
    return cnt;
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
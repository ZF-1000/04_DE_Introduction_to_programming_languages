/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

*/


using System;
using static System.Console;

Clear();
Write("Задайте размер массива: ");
int numb = Convert.ToInt32(ReadLine());
Write("Минимальный элемент массива: ");
int min_value = Convert.ToInt32(ReadLine());
Write("Максимальный элемент массива: ");
int max_value = Convert.ToInt32(ReadLine());

WriteLine($"[{String.Join(", ", FillArray(numb, min_value, max_value))}]");


int[] FillArray(int s, int min_v, int max_v)
{
    int[] array = new int[s];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min_v, max_v + 1);
    }
    return array;
}

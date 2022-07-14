/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


using System;
using static System.Console;
Clear();


Write("Введите элементы массива через запятую: ");
int[] array = GetArrayFromString(ReadLine());
Write($"{String.Join(", ", array)} -> {GetCntPositiveElem(array)}");



int GetCntPositiveElem(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        cnt += arr[i] > 0 ? 1 : 0;
    }
    return cnt;
}


int[] GetArrayFromString(string arrayStr)
{
    string[] arS = arrayStr.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arS.Length];
    for (int i = 0; i < arS.Length; i++)
    {
        result[i] = int.Parse(arS[i]);
    }
    return result;
}



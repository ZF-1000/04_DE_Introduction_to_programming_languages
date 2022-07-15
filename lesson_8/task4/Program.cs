/*
Задача 62. Заполните спирально массив 4 на 4
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/


using System;
using static System.Console;
using System.Linq;
Clear();


Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// string[] sizeS = "5 5".Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] arr = GetSpiralArray(rows, columns);
PrintArray(arr);


int[,] GetSpiralArray(int r, int c)
{
    int[,] matr = new int[r, c];
    int cnt = 1;
    int cnt_loop = 1;

    while(cnt <= r * c)
    {
        // верхние элементы -> направо
        for (int i = (cnt_loop - 1); i < cnt_loop; i++)
        {
           for (int j = 0; j < c; j++)
           {
                if (matr[i, j] != 0) continue;
                else
                {
                    matr[i, j] = cnt;
                    cnt++;
                }   
           } 
        }


        // правые элементы -> вниз
        for (int j = (matr.GetLength(1) - 1); j > (matr.GetLength(1) - 1 - cnt_loop); j--)  
        {
            for (int i = 0; i < r; i++)
            {
                if (matr[i, j] != 0) continue;
                else
                {
                    matr[i, j] = cnt;
                    cnt++;
                }
            }
        }


        // нижние элементы -> влево
        for (int i = (matr.GetLength(0) - 1); i > (matr.GetLength(0) - 1 - cnt_loop); i--)
        {
            for (int j = (matr.GetLength(1) - 1); j > -1; j--)
            {
                if (matr[i, j] != 0) continue;
                else
                {
                    matr[i, j] = cnt;
                    cnt++;
                }
            }
        }                
        

        
        // левые элементы -> вверх
        for (int j = 0; j < cnt_loop; j++)
        {
            for (int i = (matr.GetLength(0) - 1); i > -1; i--)
            {
                if (matr[i, j] != 0) continue;
                else
                {
                    matr[i, j] = cnt;
                    cnt++;
                }
            }
        }
        cnt_loop += 1;
    }

    return matr;
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
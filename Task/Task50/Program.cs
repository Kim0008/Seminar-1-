﻿//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

void FillArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 1000));
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] arr)
{
    if (a > m && b > n)
        Console.WriteLine("число за пределами массива");
    else
    {
        object returnsAB = array.GetValue(a, b);
        Console.WriteLine("число в позиции по заданным координатам: " + returnsAB);
    }
}

int[,] Yourmassiv = new int[m, n];
FillArray(Yourmassiv);
PrintArray(Yourmassiv);

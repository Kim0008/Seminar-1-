﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine();
int m = Input("Введите M: ");
int n = Input("Введите N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountSum(m, n)}");

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountSum(m, n - 1);
}

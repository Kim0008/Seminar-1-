﻿//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine();
Console.Write("Введите два положительных числа: M и N.");
Console.WriteLine();
int m = Input("M: ");
int n = Input("N: ");
Console.WriteLine();
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

 
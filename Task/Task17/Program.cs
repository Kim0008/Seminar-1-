﻿// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X не равно 0 и Y не равно 0 и выдает номер четверти плоскости, 
// в которой находится эта точка.
double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}

int GetNumChetv(double x, double y)
{
    if (x > 0 && y > 0)
    return 1;
    else 
    if (x < 0 && y > 0)
    return 2; 
    else
    if (x < 0 && y < 0)
    return 3; 
    else return 4; 
}
double x = GetNumber("x");
double y = GetNumber("y");
Console.WriteLine("Четверть: " + GetNumChetv(x,y));

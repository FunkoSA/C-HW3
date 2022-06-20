/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System;
using  static System.Console;

Clear();
WriteLine("Данная програма выводит последовательность кубов чисел от 1 до введенного числа N");
Write("Просьба ввести число: ");
int N = int.Parse(ReadLine());
WriteLine ($"Последовательность из кубов от 1 до {N} следующая:");
if (N > 0)
{
    for (int i = 1; i < N; i++)
    {
        Write ($"{Math.Pow(i,3)}, ");
    }
    WriteLine ($"{Math.Pow(N,3)}");
}
else
{
    for (int i = 1; i > N; i--)
    {
        Write ($"{Math.Pow(i,3)}, ");
    }
    WriteLine ($"{Math.Pow(N,3)}");
}
/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53


*/



using System;
using  static System.Console;

Clear();
WriteLine("Данная програма выводит расстояние между двух введенных координат в 3D пространстве ");
Write ("Введите координаты первой точки (A) по осям Х: ");
int X1 = int.Parse(ReadLine());
Write (" Y: ");
int Y1 = int.Parse(ReadLine());
Write (" Z: ");
int Z1 = int.Parse(ReadLine());
WriteLine();
Write ("Введите координаты второй точки (B) по осям Х: ");
int X2 = int.Parse(ReadLine());
Write (" Y: ");
int Y2 = int.Parse(ReadLine());
Write (" Z: ");
int Z2 = int.Parse(ReadLine());

WriteLine ($"Расстояние между точками A ({X1},{Y1},{Z1}) и B ({X2},{Y2},{Z2}) следующее: {Math.Sqrt(Math.Pow(X2 - X1,2)+Math.Pow(Y2 - Y1,2)+Math.Pow(Z2 - Z1,2)):f2}");
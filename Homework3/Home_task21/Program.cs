// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using static System.Console;
Clear();
WriteLine("Домашнее задание №21");
WriteLine("");
WriteLine("Для точки А введите координаты:");
Write("X = ");
double.TryParse(ReadLine(), out double AX);
Write("Y = ");
double.TryParse(ReadLine(), out double AY);
Write("Z = ");
double.TryParse(ReadLine(), out double AZ);

WriteLine("Для точки B введите координаты:");
Write("X = ");
double.TryParse(ReadLine(), out double BX);
Write("Y = ");
double.TryParse(ReadLine(), out double BY);
Write("Z = ");
double.TryParse(ReadLine(), out double BZ);
WriteLine($"Длина между точками L= {Math.Pow(Math.Pow(BX - AX, 2) + Math.Pow(BY - AY, 2) + Math.Pow(BZ - AZ, 2), 0.5):f2}");
WriteLine("");
WriteLine("--КОНЕЦ--");
WriteLine("");
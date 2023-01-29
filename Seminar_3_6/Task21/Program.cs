// Напишите программу, которая определяет расстояние между 2-мя точками
using static System.Console;
Clear();
Write ("Введите  координаты Х точки а:");
int.TryParse (ReadLine(), out int aX);
Write ("Введите  координаты Y точки а:");
int.TryParse(ReadLine(), out int aY);
Write ("Введите  координаты X точки b:");
int.TryParse(ReadLine(), out int bX);
Write ("Введите  координаты Y точки b:");
int.TryParse(ReadLine(), out int bY);

double Lenght = Math.Sqrt(Math.Pow((aX-bX),2)+Math.Pow((aY-bY),2));
WriteLine ($"{Lenght:f2}");
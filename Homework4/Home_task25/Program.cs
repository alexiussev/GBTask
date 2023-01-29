// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// При решении задач обязательным условием является реализация методов

using static System.Console;
Clear();

WriteLine("Домашнее задание №25");
WriteLine("");

Write("Введите первое число: ");
int.TryParse(ReadLine(), out int Number1);

Write("Введите второе число: ");
int.TryParse(ReadLine(), out int Number2);

WriteLine($"{Number1}^{Number2}={MetodPow(Number1, Number2)}");

WriteLine("");
WriteLine("Конец");

double MetodPow(double A, int B)
{
    int count = 0;
    double result = 1;

    if (B > 0)
    {
        while (count < B)
        {
            result *= A;
            count++;
        }
    }

    if (B < 0)
    {
        B = B * (-1);
        while (count < B)
        {
            result = result * (1 / A);
            count++;         
        }
        
    }

    if (A == 0 && B == 0) 
    {
        result = 0;
    }
    return result;
}


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

using static System.Console;
Clear();

WriteLine("Домашнее задание - задача 6");

Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());

if (number % 2 == 0) 
    WriteLine("Да, четное число");
        else
        WriteLine("Нет, нечетное число");

Write("---Конец---");
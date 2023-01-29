// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using static System.Console;
Clear();

WriteLine("Домашнее задание - задача 2");

Write("Введите 1-ое число: ");
double first_number = Convert.ToDouble(Console.ReadLine());

Write("Введите 2-ое число: ");
double second_number = Convert.ToDouble(Console.ReadLine());

if (first_number > second_number)
{
    WriteLine($"MAX = {first_number}, MIN = {second_number}");
}
if (second_number > first_number)
{
WriteLine($"MAX = {second_number}, MIN = {first_number}");   
}
if (second_number == first_number)
WriteLine($"Оба числа одинаковые и равны: {first_number}"); 
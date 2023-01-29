// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using static System.Console;
Clear();

WriteLine("Домашнее задание - задача 8");

Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= number)
{
if (index%2==0) Write($"{index},");

index++;
}
WriteLine();
Write("---Конец---");
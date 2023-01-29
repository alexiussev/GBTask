// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using static System.Console;
Clear();
WriteLine("Домашнее задание - задача 4");
int[] number = new int[3];


Write("Введите 1-ое число: ");
number[0] = Convert.ToInt32(Console.ReadLine());

Write("Введите 2-ое число: ");
number[1] = Convert.ToInt32(Console.ReadLine());

Write("Введите 3-ое число: ");
number[2] = Convert.ToInt32(Console.ReadLine());

int index = 0;
int result = number[0];

while (index < 2)
{
index+=1;
if (result < number[index])
{
    result = number[index];
}
}
WriteLine($"MAX = {result}"); 
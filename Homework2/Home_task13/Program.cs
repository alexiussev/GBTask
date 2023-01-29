﻿//При решении задачи 10 и 13 НЕ ИСПОЛЬЗОВАТЬ индексы обращения к символу строки.
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

using static System.Console;
Clear();
WriteLine("Домашнее задание №13");
WriteLine("");
Write("Введите произвольное число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine(number < 100 ? "Третьей цифры нет" : number / 100 % 10);
WriteLine("");
WriteLine("--КОНЕЦ--");
// Задача 19
// В решении не использовать обращение к символу строки. Только математические методы работы с числами
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using static System.Console;
Clear();
WriteLine("Домашнее задание №19");
WriteLine("");

Link1:// для оператора goto

Write("Введите целое пятизначное целое число: ");
// int.TryParse(ReadLine(), out int Number);

bool isParse = int.TryParse(ReadLine(), out int Number);

if (!isParse || Number / 10000 < 1 || Number / 10000 > 10)
{
    WriteLine("Ошибка Введите целое 5 значное число");
    WriteLine("");
    goto Link1;
}

WriteLine(Number% 10==Number/10000 % 10 && Number/10 % 10 == Number/1000 % 10?"Да, число являетяс полиндромом":"Нет, число не полиндром");

// WriteLine(Number% 10);
// WriteLine(Number/10 % 10);
// WriteLine(Number/100 % 10);
// WriteLine(Number/1000 % 10);
// WriteLine(Number/10000 % 10);

WriteLine("--КОНЕЦ--");
WriteLine("");
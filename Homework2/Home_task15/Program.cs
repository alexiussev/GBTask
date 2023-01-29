// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using static System.Console;
Clear();
WriteLine ("Домашнее задание №13");
WriteLine ("");

Link1:// для оператора goto

Write ("Введит день недели цифрой от 1 до 7: ");
int NumberDay = Convert.ToInt32(ReadLine());

if (NumberDay>7 || NumberDay<1) 
{
    WriteLine ("Повнимательнее!");
    goto Link1;
}

WriteLine(NumberDay>5?"да, номер дня является выходным":"нет, номер дня является рабочим");
WriteLine("--КОНЕЦ--");
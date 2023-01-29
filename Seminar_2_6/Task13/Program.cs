// Напишите программу которое принимает на вход число и проверяет кратно ли оно и 7 и 23
using static System.Console;
Clear();

Write("Введите число:");
int number = Convert.ToInt32(ReadLine());
WriteLine(number % 7 == 0 ? "число кратно 7" : number % 23 == 0 ? "число кратно 23" : "число не кратно ни 7, ни 23");
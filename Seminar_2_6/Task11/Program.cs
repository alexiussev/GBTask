// Напишите программы которое выводит случайное трехзначное число и удаляет цифру второго числа
using static System.Console;
Clear();
int number= new Random().Next(100,1000);
WriteLine(number);
WriteLine($"{number/100}{number%10}");
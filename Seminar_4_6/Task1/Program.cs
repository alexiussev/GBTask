// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using static System.Console;
Clear();

Write("Введите число: ");
// int number = int.Parse(ReadLine()!);
int.TryParse(ReadLine(), out int number);
WriteLine($"Количество чисел: {CountNum(number)}");                   

int CountNum(int a)
{
    int result = 0;
    while(a > 0)
    {
        a /=10;
        result++;
    }
    return result;
}
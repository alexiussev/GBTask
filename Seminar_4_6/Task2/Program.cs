// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

WriteLine($"Произведение чисте от 1 до {number}: {CountNum(number)}");                   

Int64 CountNum(int a)
{
    int result = 1;
    while(a > 0)
    {                                                             
        result *= a ;
        a--;
    }
    return result;
}
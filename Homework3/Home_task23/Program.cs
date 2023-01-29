// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();

WriteLine("Домашнее задание №23");
WriteLine("");
Write("Введите целое число: ");

Link1:

bool IsPurse=int.TryParse (ReadLine(), out int Number);
if (!IsPurse)
{
    Write("Ошибка, введите целое число: ");
    goto Link1;
}

if (Number>0)
{
    int ind=1;
    while (ind<Number)
    {
        Write($"{Math.Pow(ind,3)}, ");
        ind++;
    }
    WriteLine($"{Math.Pow(ind++,3)}");    
}

if (Number<0)
{
    int ind=-1;
    while (ind>Number)
    {
        Write($"{Math.Pow(ind,3)}, ");
        ind--;
    }
    WriteLine($"{Math.Pow(ind--,3)}");    
}

WriteLine("");
WriteLine("--КОНЕЦ--");
WriteLine("");
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

Write("Введите ряд чисел: ");
string[] Array = ReadLine()!.Split (" ", StringSplitOptions.RemoveEmptyEntries);

HowManyPositiveNumbers(Array);

WriteLine("");
WriteLine($"в массиве [ {string.Join(" ", Array)} ] всего {HowManyPositiveNumbers(Array)} положительных чисел");
WriteLine("");

int HowManyPositiveNumbers(string[] Array)
{
    int Count = 0;
    foreach (var element in Array)
    {
        int.TryParse(element, out int A);
        if (A>0) 
        {
            Count++;
        }
    }
    return Count;
}
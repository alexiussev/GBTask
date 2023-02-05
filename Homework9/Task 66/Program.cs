// При решении задач обязательным условием является реализация рекурсивных методов
// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();
Write("Введите диапазон натуральных числе через запятую: ");
string[] InputParameters = ReadLine()!.Split(new string[] {"," , " "}, StringSplitOptions.RemoveEmptyEntries);
int.TryParse(InputParameters[0], out int number1);
int.TryParse(InputParameters[1], out int number2);
WriteLine(SumNumbersBetween (number1, number2));

int SumNumbersBetween (int n1, int n2)
{
    if (n1>n2) return 0;
    else return SumNumbersBetween (n1+1, n2)+n1;
}

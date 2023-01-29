// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

WriteLine("Домашнее задание №27");
WriteLine("");

Write("Введите любое число: ");
int.TryParse(ReadLine(), out int Number);

PrintOutSumNumbers(Number);

// МЕТОДЫ:
void PrintOutSumNumbers(int A)
{
    int Sum = 0;
    int B = 0;
    if (A >= 0)
    {
        while (A > 0)
        {
            B = A % 10;
            A /= 10;
            Sum += B;
        }
    }
    else
    {
        A = Math.Abs(A);
        while (A > 0)
        {
            B = A % 10;
            A /= 10;
            Sum += B;
        }
        Sum = Sum - 2 * B;
    }

    WriteLine("Сумма всех цифр в числе равна  = " + Sum);
    WriteLine("---КОНЕЦ---");
    WriteLine("");
}
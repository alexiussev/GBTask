using static System.Console;
Clear();

// WriteLine ("Привет!");
// string num = ReadLine();
// int number = int.Parse();

// Напишите программу, которая принимает число А и выдает суммму числе от одного до А

Write ($"Введите целое число 1..A: ");
int number = int.Parse(ReadLine()!);
int sum1=GetSum(number);
WriteLine ($"Сумма чисел от 1 до {number} = {sum1}");

int GetSum(int A)
{
    int result = 0;
    while (A>0)
    {   
        result += A;
        A--;
    }
    return result;
}
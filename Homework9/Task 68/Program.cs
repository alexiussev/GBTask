// При решении задач обязательным условием является реализация рекурсивных методов
// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();
Write ("Введите два неотрицательных целых числа:");
string[] inputParameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
double.TryParse(inputParameters[0], out double numberM);
double.TryParse(inputParameters[1], out double numberN);
WriteLine($"{numberM}-{numberN}");
double result = fuctionAkermana(numberM, numberN);
WriteLine (result!=-999?$"A({numberM},{numberN})={result}":"Нужно было вводить положительные числа");

double fuctionAkermana (double M, double N)
{
    if (M==0) return N+1;
    if (M>0 && N==0) return fuctionAkermana (M-1,1);
    if (M>0 && N>0) return fuctionAkermana (M-1,fuctionAkermana(M, N-1));
    return -999;
}
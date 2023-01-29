// Задача 38: Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами
// и вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();
WriteLine("Домашнее задание №38");
WriteLine("");

Write("Введите размер масcива: ");
         int.TryParse(ReadLine(), out int SizeArray);

Write("Введите диапазон min max случайных целых чисел массива через пробел: ");
string[] ArrayMinMax = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] mainArray = FullArray(SizeArray, int.Parse(ArrayMinMax[0]), int.Parse(ArrayMinMax[1]));

PrintArray(mainArray);
WriteLine("");
PrintdefMaxMin(mainArray);
WriteLine("");
WriteLine("---КОНЕЦ---");
WriteLine("");


double RANDOM_point_00(int Min, int Max)
{
    double RND = new double();
    RND = new Random().Next(Min * 100, Max * 100 + 1);
    double RND1 = RND / 100;
    return RND1;
}

double[] FullArray(int size, int min, int max)
{
    double[] Array = new double[size];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = RANDOM_point_00(min, max);
    }
    return Array;
}

void PrintdefMaxMin (double[] Array)
{
    double min=0;
    double max=0;
    
    foreach (var element in mainArray)
    {
        if (element < min) 
        {
            min = element;
        }
        if (element > max) 
        {
            max = element;
        }
    }
    WriteLine($"Максимальное число: {max} Минимальное число: {min}");
    WriteLine($"Разницы между максимальным и минимальным элементов массива -> {max-min}");
}

void PrintArray(double[] Array)
{
    Write("[");
    foreach (var a in Array)
    {
        Write($" {a} ");
    }
    Write("]");
}
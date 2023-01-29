// Задача 36: Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

WriteLine("Домашнее задание №36");
WriteLine("");


Write("Введите размер масcива: ");
int.TryParse(ReadLine(), out int SizeArray);

Write("Введите диапазон min max случайных чисел массива через пробел: ");
string [] ArrayMinMax = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int [] mainArray = FullArray (SizeArray, int.Parse(ArrayMinMax [0]), int.Parse(ArrayMinMax [1]));

PrintArray(mainArray);
WriteLine("");
Write("Сумма всех нечетных элементов -> ");
OddSumInArray(mainArray);

WriteLine("");
WriteLine("---КОНЕЦ---");
WriteLine("");

int[] FullArray (int size, int min, int max)
{
    int [] Array = new int [size];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i]=new Random().Next(min, max+1);
    }
    return Array;
}

void OddSumInArray (int [] Array)
{
    int sum = 0;

    foreach (var a in Array)
    {
        sum+=(a%2==0?0:a);
        // Write($"{sum}-");
        // WriteLine(a%2);
    }
    WriteLine(sum);
}

void PrintArray (int[] Array)
{
    Write ("[");
    foreach (var a in Array)
    {
        Write ($" {a} ");
    }
    Write ("]");
}
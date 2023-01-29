// Задача 34: Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами,
// и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

WriteLine("Домашнее задание №34");
WriteLine("");

Write("Введите размер масcива: ");
int.TryParse(ReadLine(), out int SizeArray);

int[] mainArray = FullArray(SizeArray);

PrintArray(mainArray);
WriteLine("");

Write("Количество четных элементов массива -> ");
EvenOnce(mainArray);

WriteLine("");
WriteLine("---КОНЕЦ---");
WriteLine("");



//Методы:

int[] FullArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1, 1000);
    }
    return Array;
}

void EvenOnce(int[] Array)
{
    int HowMany = 0;
    foreach (var a in Array)
    {
        HowMany+=a%2==0?1:0;
        // Write($"{sum}-");
        // WriteLine(a%2);
    }
    WriteLine(HowMany);
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
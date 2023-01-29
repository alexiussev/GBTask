// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

using static System.Console;
Clear();

int[] arr = GetArray();
PrintArray (arr);


int[] GetArray()
{
    int[] Array = new int [8];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0,2);
    }
    return Array;
}

void PrintArray (int [] Array)
{
    int count = Array.Length;
    int i = 0;
    while (i <  count)
    {
        Write($"{Array [i]} ");
        i++;
    }
    WriteLine("");
}
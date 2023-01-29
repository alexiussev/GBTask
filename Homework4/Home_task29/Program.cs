// Задача 29: Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();

WriteLine("Домашнее задание №29");
WriteLine("");

int[] Arr = GetArray();
PrintArray(Arr);

int[] GetArray()
{
    int[] Array = new int [8];
    for (int i = 0; i < 8; i++)
    {
        Array[i] = new Random().Next(-2147483648, 2147483647); //int: хранит целое число от -2147483648 до 2147483647
    }                                                         //и занимает 4 байта. Представлен системным типом System.Int32
    return Array;
}

void PrintArray(int [] Array)
{
   
   
    Write ("[");
    for (int i = 0; i < Array.Length-1; i++)
    {
        Write ($"{Array[i]}, ");
    }
    Write ($"{Array[Array.Length-1]} ]");
    
    WriteLine("");
    WriteLine("---КОНЕЦ---");
    WriteLine("");
}
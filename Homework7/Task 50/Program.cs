// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;
Clear();

Write("Введите размер массива (строки х столбцы) MхN: ");
string enterText = ReadLine()!;
string[] inputParameters1 = enterText.Split(new string[] { " ", ",", "/", "x", "X", "х", "Х" }, StringSplitOptions.RemoveEmptyEntries);

int[,] arrayM = GettingRandomArray(int.Parse(inputParameters1[0]), int.Parse(inputParameters1[1]));
PrintArray(arrayM);

Write("Введите индекс позиции в массиве i, j: ");
string[] inputParameters2 = ReadLine()!.Split(new string[] { " ", ";", ".", ",", "/", "-" }, StringSplitOptions.RemoveEmptyEntries);
int indexI = int.Parse(inputParameters2[0]);
int indexJ = int.Parse(inputParameters2[1]);

PrintIndexValue(arrayM, indexI, indexJ);

int[,] GettingRandomArray(int m, int n)
{
    Random rnd = new Random();
    int[,] rndArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            rndArray[i, j] = rnd.Next(-10, 11);
        }
    }
    return rndArray;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Write($"{array[i, j], 5} ");
        }
        WriteLine();
    }
}

void PrintIndexValue(int[,] array, int m, int n)
{
    if (m < array.GetLength(0) && n < array.GetLength(1))
    { WriteLine($"С этим индексам соответсвут число:{array[m, n]}");}
    else WriteLine("Данная позиция отсутствует");
}
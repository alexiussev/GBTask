// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();
Write("ВВедите размер массива (строки/столбцы) mхn: ");
string enterText = ReadLine()!;

string[] parameters = enterText.Split(new string[] { " ", ",", "/", "-" }, StringSplitOptions.RemoveEmptyEntries);
int.TryParse(parameters[0], out int nRows);
int.TryParse(parameters[1], out int mColums);

int[,] mainArray = GetRandomArray(nRows, mColums);
PrintArray(mainArray);
FindMinimumSummaInRows(mainArray);
WriteLine();
WriteLine();

int[,] GetRandomArray(int m, int n)
{
    Random RND = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           array [i, j] = RND.Next(-99, 100);
        }
    }
    return array;
}

void FindMinimumSummaInRows(int[,] array)
{
    int[] arrayWithSummOfRows = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summaRows = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summaRows += array[i, j];
        }
        arrayWithSummOfRows[i] = summaRows;
    }

    WriteLine($"Сумма по строкам [{String.Join(", ", arrayWithSummOfRows)}]");
    
    int min = arrayWithSummOfRows[0];
    for (int i = 0; i < arrayWithSummOfRows.Length; i++)
    {
        min=arrayWithSummOfRows[i]<min?arrayWithSummOfRows[i]:min;
    }

    WriteLine($"Минимальная сумма в массиве построчно: {min}");
    Write($"Номер строки с минимальной суммой: ");
    for (int i = 0; i < arrayWithSummOfRows.Length; i++)
    {
        if (min==arrayWithSummOfRows[i])
        {
            Write($"-{i+1}-");
        }
    }
}

void PrintArray(int[,] array)
{
    WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j],5}");
        }
        WriteLine();
    }
    WriteLine();
}
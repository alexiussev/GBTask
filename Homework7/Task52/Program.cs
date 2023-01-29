// Задача 52. Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();

int[,] arrayManual =     {{1, 4, 7, 2},
                          {5, 9, 2, 3},
                          {8, 4, 2, 4}};

PrintArray(arrayManual);
GetAverageColums(arrayManual);

void GetAverageColums(int[,] array)
{
    Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa =0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summa+=array[i,j];
        }
        double Answer = summa/array.GetLength(0);

        //Write($"{Math.Round(Answer,1)} ");
        Write($"{Answer:0.0} ");

    }
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
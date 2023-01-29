// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using static System.Console;
Clear();

Write("Задайте размер двухмерного массива с целыми числами m, n (строки/столбцы): ");
string[] InputParameters = ReadLine()!.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

int.TryParse(InputParameters[0], out int nRows);
int.TryParse(InputParameters[1], out int mColums);

int[,] mainArray = GetRandomArray(nRows, mColums);

PrintArray(mainArray);

SortRowArray (mainArray);
PrintArray(mainArray);

int[,] GetRandomArray(int m, int n)
{
    Random RND = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = RND.Next(-99, 100);
        }
    }
    return array;
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

int[,] SortRowArray (int[,] array)
{
    int temp=new int();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j =0;
        while ( j < array.GetLength(1)-1)
        {
            if (array [i,j]<array [i,j+1])
            {
                temp=array [i,j];
                array [i,j] = array [i,j+1];
                array [i,j+1] = temp;
                j=0;
            }       
            else j++;    
        }
    }
    return array;
}
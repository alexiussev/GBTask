// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();

Write("Задайте размер певой и второй матрицы (строки столбцы) в формате m1 n1 / m2 n2: ");
string enterText = ReadLine()!;
string[] parameters = enterText.Split(new string[] { "," , " " , "/" , "-" , }, StringSplitOptions.RemoveEmptyEntries);

int[,] arrayMain1 = GetRandomArray(int.Parse(parameters[0]),int.Parse(parameters[1]));
int[,] arrayMain2 = GetRandomArray(int.Parse(parameters[2]),int.Parse(parameters[3]));
int[,] arrayMainResult = MultiplicationArrays (arrayMain1, arrayMain2);
WriteLine();
WriteLine("Матрица 1:");
PrintArray(arrayMain1);
WriteLine("Матрица 2:");
PrintArray(arrayMain2);
WriteLine("Матрица 1 х Матрицу 2:");
PrintArray(arrayMainResult);


int[,] GetRandomArray(int m, int n)
{
    Random RND = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           array [i, j] = RND.Next(-9, 10);
        }
    }
    return array;
}

int[,] MultiplicationArrays(int[,] array1,int[,] array2)
{
    int N=new int();
    int M=new int();
    int summ=0;
    
     if (array1.GetLength(0)<=array2.GetLength(1)) //НЕ СТАЛ ВВОДИТЬ УСЛОВИЯ УМНОЖЕНИЕ НЕ ВОЗМОЖНО
    {N=array1.GetLength(0);}                       //РЕШИЛ ОБРЕЗАТЬ МАТРИЦУ ДЛЯ ВОЗМОЖНОГО УМНОЖЕНИЯ
    else {N=array2.GetLength(1);}
    
    if (array1.GetLength(1)<=array2.GetLength(0))
    {M=array1.GetLength(1);}
    else {M=array2.GetLength(0);}

    int[,] arrayMulti = new int[N,M];

 // ПРОВЕРКА ЧИСЕЛ ПРИ ОБРЕЗКЕ
 // WriteLine($"*** обрезка матрицы для возможности умножения до размера {M},{N}");

    for (int k = 0; k < M; k++)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                summ=summ+array1[i,j]*array2[j,k];
            }
            arrayMulti[i,k] =summ;
            summ=0;
        }
    } 
  
    return arrayMulti;
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
// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();
Write("Введите размер массива (строки х столбцы) MхN: ");

string enterText = ReadLine()!;
string[] parameters = enterText.Split(new string[] { " ", ",", "/", "x", "X", "х", "Х" }, StringSplitOptions.RemoveEmptyEntries);
PrintGettingRandomArray(int.Parse(parameters[0]), int.Parse(parameters[1]));


void PrintGettingRandomArray(int m, int n)
{
    Random rnd = new Random();
    double[,] rndArray = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            rndArray[i, j] = Convert.ToDouble(rnd.Next(-100,100)/10.0);
            Write($"{rndArray[i, j],5} ");
        }
        WriteLine("");
    }
}
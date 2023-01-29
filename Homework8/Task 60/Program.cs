// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

Write("Введите размер массива (строки/столбцы/ряды) M N Z: ");
string enterText1 = ReadLine()!;

string[] parameters1 = enterText1.Split(new string[] { " ", ",", "/", "-" }, StringSplitOptions.RemoveEmptyEntries);
int.TryParse(parameters1[0], out int nRows);
int.TryParse(parameters1[1], out int mColums);
int.TryParse(parameters1[2], out int zRanks);

Write("Введите целочисленный диапазон генерации случайных числе min max: ");
string enterText2 = ReadLine()!;

string[] parameters2 = enterText2.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
int.TryParse(parameters2[0], out int rndMin);
int.TryParse(parameters2[1], out int rndMax);

int[,,] mainArray = RandomNumberInThreeArrayNotRepetition(nRows, mColums, zRanks, rndMin, rndMax);
PrintArray(mainArray);

int[,,] RandomNumberInThreeArrayNotRepetition(int nROWS, int mCOLUMS, int zRANKS, int sizeRndMin, int sizeRndMaх)
{
    int[,,] array = new int [nROWS, mCOLUMS, zRANKS];
    int[] arrayFor = new int[1];
        
    if (array.GetLength(0)*array.GetLength(1)*array.GetLength(2) <= sizeRndMaх - sizeRndMin +1 )
    {
        Random RND = new Random();
        arrayFor[0] = RND.Next(sizeRndMin, sizeRndMaх+1);
        int number = new int();
        //WriteLine($"1- [{String.Join(", ", arrayFor)}]"); // *** проверка
      

        for (int i = 1; i < array.GetLength(0)*array.GetLength(1)*array.GetLength(2); i++)
        {
        Array.Resize(ref arrayFor, i+1);
        Link1:
            arrayFor[i] = RND.Next(1, sizeRndMaх+1);
            number = arrayFor[i];
            for (int k = 1; k < arrayFor.Length; k++)
            {
                if (number == arrayFor[k - 1]) goto Link1;
            }
        }
        
        //WriteLine($"2- [{String.Join(", ", arrayFor)}]"); // *** проверка

        int index = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int z = 0; z < array.GetLength(2); z++)
                {
                    array[i, j, z] = arrayFor[index];
                    index++;
                }
            }
        }
        return array;
    }
    else
    {
        WriteLine("Размер массива не позволяетя заполнить неповтояющимися числами ввиду малого диапазона случайных чисел");
        return array;
    }
}

void PrintArray(int[,,] array)
{
    WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Write($"{array[i, j, z]}({i},{j},{z})   ");
            }
            WriteLine();
        }
    }
    WriteLine();
}
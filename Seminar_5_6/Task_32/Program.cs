// адача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

using static System.Console;
Clear();
Write("Введите макимальный возможный размер массива: ");
int sizeIN = int.Parse(ReadLine()!);
int sizeRND = new Random().Next(1, sizeIN);


int[] FirstArray = FullArray(sizeRND);
int[] ResultArray = NegativingArray(FirstArray);

PrintArray(FirstArray);
Write("->");
PrintArray(ResultArray);


int[] FullArray (int SIZE)
{
    int[] Array1 = new int [SIZE];
    
    for (int i = 0; i < Array1.Length; i++)
    {
        Array1[i]=new Random().Next(-99, 99);
    }
    return Array1;
}

int [] NegativingArray (int[] Array1)
{
    int [] Array2 = new int [Array1.Length];
    for (int i = 0; i < Array1.Length; i++)
    {
        Array2[i]=Array1[i]*-1;
    }
    return Array2;
}

void PrintArray (int[] Array)
{
    Write ("[");
    foreach (var a in Array)
    {
        Write ($"{a} ");
    }
    Write ("]");
}
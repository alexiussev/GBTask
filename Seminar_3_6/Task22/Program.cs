//Вывести квадраты чисел от 1 до N
using static System.Console;
Clear();
Write ("Введите число для ввода таблицы квадратов от 1 до N: ");
int.TryParse(ReadLine(), out int n);

int i=1;
 while (i<n+1)
 {
    WriteLine("Число " + i + " Квадрат " + Math.Pow(i,2));
    i++;
 }

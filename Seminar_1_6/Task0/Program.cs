using static System.Console;

WriteLine ("Введите число: ");

int a=int.Parse(ReadLine()!);
//int a=Convert.ToInt32(ReadLine());
WriteLine($"Квадрат числа {a} равен {a*a}");
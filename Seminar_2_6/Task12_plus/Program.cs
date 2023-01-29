using static System.Console;
Clear();

Write("Введите 1-ое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Write("Введите 2-ое число: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Write(a1 == a2 ? "=" : a1 > a2? ">" : "<");
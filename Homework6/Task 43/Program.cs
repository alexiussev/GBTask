// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();
Write("введите K1 и B1 для формулы Y=K*X+B: "); Point N1 = GetPointFromString(ReadLine()!);
Write("введите K2 и B2 для формулы Y=K*X+B: "); Point N2 = GetPointFromString(ReadLine()!);

WriteLine($"");
WriteLine($"{FindLinesIntersection(N1.K, N1.B, N2.K, N2.B)}");
WriteLine($"");

//Point A = new Point();
Point GetPointFromString(string inStr)
{
    Point res = new Point();
    string[] par = inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    res.K = double.Parse(par[0]);
    res.B = double.Parse(par[1]);
    return res;
}

string FindLinesIntersection(double k1, double b1, double k2, double b2)
{
    string answeer = "";
    if (k1 - k2 != 0)
    {
        double X = (b2 - b1) / (k1 - k2);
        double Y = k1 * X + b1;
        answeer = $"Пересечение данных фукций Y={k1}x+{b1} и Y={k2}x+{b2} в точке (X;Y)=({X};{Y})";
        return answeer;
    }

    if (k1 == k2 && b1 == b2)
    {
        answeer = $"Функции идеинтичны и накладываются друг на друга";
        return answeer;
    }
    answeer = $"Функции параллельны и не пересекаются" ;
    return answeer;
}
struct Point
{
    public double K;
    public double B;
}



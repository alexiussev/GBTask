//**Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
using static System.Console;
Clear();
WriteLine("введите координаты А через пробел:");
Point A= GetPointFromString(ReadLine()!);
WriteLine("введите координаты В через пробел:");
Point B= GetPointFromString(ReadLine()!);

double delta = Math.Sqrt(Math.Pow(A.X-B.X,2)+Math.Pow(A.Y-B.Y,2));
WriteLine(delta);


//Point A = new Point();

Point GetPointFromString(string inStr)
{
    Point res = new Point();
    string[] par=inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
res.X=int.Parse(par[0]);
res.Y=int.Parse(par[1]);
return res;
}

struct Point
{   
    public int X;
    public int Y;
}
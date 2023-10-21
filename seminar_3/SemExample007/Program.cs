// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

double dist(int ax, int ay, int bx, int by)
{
  double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
  return result;
}

int ax = Input("Введите Ax: "),
    ay = Input("Введите Ay: "),
    bx = Input("Введите Bx: "),
    by = Input("Введите BY: ");

// AB = √(xb - xa)2 + (yb - ya)2

System.Console.WriteLine("Distance beetwen = " + dist(ax, ay, bx, by));


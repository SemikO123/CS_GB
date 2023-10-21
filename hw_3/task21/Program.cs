// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

double dist(int[] A, int[] B)
{
  double result = Math.Sqrt(Math.Pow(B[0] - A[0], 2) 
                          + Math.Pow(B[1] - A[1], 2) 
                          + Math.Pow(B[2] - A[2], 2));
  return result;
}

int[] pointA = {Input("Введите Ax: "),
                Input("Введите Ay: "),
                Input("Введите Az: ")};

int[] pointB = {Input("Введите Bx: "),
                Input("Введите By: "),
                Input("Введите Bz: ")};
    
// AB = √(xb - xa)2 + (yb - ya)2

Console.WriteLine("Distance beetwen = " + Math.Round(dist(pointA, pointB), 2));
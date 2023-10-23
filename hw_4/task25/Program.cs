// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

long Pow(int num1, int num2)
{
  long res = 1;
  for (int i = 0; i < num2; i++)
  {
    res *= num1;
  }
  return res;
}


int A = Input("input A: "),
    B = Input("Input B: ");

System.Console.WriteLine($"{A}^{B} = {Pow(A,B)}");

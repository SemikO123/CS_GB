// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Factorial(int num)
{
  int fact = 1;
  for (int i = 1; i <= num; i++)
  {
    fact *= i;
  }
  return fact;
}

int num = Input("Введите натуральное число: ");
System.Console.WriteLine($"{num}! = {Factorial(num)}");
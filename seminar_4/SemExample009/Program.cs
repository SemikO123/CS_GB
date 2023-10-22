// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int CalcSum(int num)
{
  int sum = 0;
  for (int i = 1; i <= num; i++)
  {
    sum += i;
  }
  return sum;
}

int num = Input("Введите натуральное число: ");
System.Console.WriteLine($"Сумма чисел от 1 до {num} = {CalcSum(num)}");


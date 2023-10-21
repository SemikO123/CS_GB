// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int N = Input("Введите N: ");

for (int i = 1; i <= N; i++)
{
  // Вариант 1
  // string str = string.Empty;
  // if (i != N) str = ", ";
  // Console.Write(Math.Pow(i, 3) + str);

  // Вариант 2
  // if (i == N) Console.Write(Math.Pow(i, 3));
  // else Console.Write(Math.Pow(i, 3) + ", ");

  // Вариант 3
  Console.Write(Math.Pow(i, 3) + ((i != N) ? ", " : ""));
}
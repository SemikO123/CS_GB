// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int N = Input("Введите N: ");

for (int i = 1; i <= N; i++)
{
  // string str = "";
  // if (i == N) str = " ";
  // else str = ", ";
  // Console.Write(Math.Pow(i, 2) + str);

  if (i == N) Console.Write(Math.Pow(i, 2));
  else Console.Write(Math.Pow(i, 2) + ", ");

  // Console.Write(Math.Pow(i, 2) + ((i != N) ? ", " : ""));
}
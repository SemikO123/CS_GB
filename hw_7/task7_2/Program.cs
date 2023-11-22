// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

// Основное решение
int Acc(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Acc(m - 1, 1);
  else return Acc(m - 1, Acc(m, n - 1));
}

// "Энакин, ты должен был улучшить читаемость..."
int Acc2(int m, int n)
{
  return m == 0 
      ? n + 1
      : n == 0
        ? Acc2(m - 1, 1)
        : Acc(m - 1, Acc(m, n - 1));
}

int m = Input("Введите число M: "),
    n = Input("Введите число N: ");

System.Console.WriteLine(Acc(m,n));
System.Console.WriteLine(Acc2(m,n));

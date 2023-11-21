// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример

// N=5 => 1 2 3 4 5

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void PrintNumbers(int N, int i = 1)
{
  
  System.Console.Write($"{i} ");
  if (i < N) PrintNumbers(N, i + 1);
}

void PrintNumbers2(int N)
{
  if (N > 1) PrintNumbers2(N - 1);
  System.Console.Write($"{N} ");
}

string Numbers(int N, int i = 1)
{
  // if (i > N) return "";
  // return i + " " + Numbers(N, i + 1);
  return i > N ? "" : i + " " + Numbers(N, i + 1);
}

int n = Input("Введите число: ");

System.Console.WriteLine("1st method: ");
PrintNumbers(n);
System.Console.WriteLine();
System.Console.WriteLine("------------------");
System.Console.WriteLine("2nd method: ");
PrintNumbers2(n);
System.Console.WriteLine();
System.Console.WriteLine("------------------");
System.Console.WriteLine("3rd method: ");
System.Console.WriteLine(Numbers(n));

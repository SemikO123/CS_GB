// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

// сами M и N включаются в вывод, т.к. нет явного указания обратного
void PrintNumbers(int M, int N)
{
  if (M <= N)
  {
    System.Console.Write($"{M} ");
    PrintNumbers(M + 1, N);
  } 
}

int m = Input("Введите число M: "),
    n = Input("Введите число N: ");

PrintNumbers(m, n);
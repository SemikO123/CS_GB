// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] Getmatrix(int len1, int len2, int a, int b)
{
  int[,] matrix = new int[len1,len2];
  b++; // Генерировать будем до b включительно
  Random rand = new Random();
  for (int i = 0; i < len1; i++)
  {
    for (int j = 0; j < len2; j++)
    {
      matrix[i,j] = rand.Next(a, b);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write("{0, 3} ", matrix[i, j]);
    }
    System.Console.WriteLine();
  }
}

int m = Input("Введите кол-во строк: "),
    n = Input("Введите кол-во стобцов: ");

int[,] arr = Getmatrix(m, n, 0, 999) ;
System.Console.WriteLine("Матрица: ");
PrintMatrix(arr);
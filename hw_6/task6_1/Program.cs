// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

//метод генерирующий матрицу заполненную рандомными ASCII символами в диапазоне кодов от a до b
char[,] Getmatrix(int len1, int len2, int a, int b)
{
  char[,] matrix = new char[len1, len2];
  b++; // Генерировать будем до b включительно
  Random rand = new Random();
  for (int i = 0; i < len1; i++)
  {
    for (int j = 0; j < len2; j++)
    {
      matrix[i, j] = (char)rand.Next(a, b);
    }
  }
  return matrix;
}

string ConcatMatrix(char[,] matrix)
{
  string str = string.Empty;
  foreach (char symbol in matrix)
  {
    str += symbol;
  }

  return str;
}

void PrintMatrix(char[,] matrix)
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

//тестовый массив
char[,] matrix1 = new char[,]
{
  {'Э','Т','о','Д','л','и',},
  {'н','н','а','я',' ','с',},
  {'т','р','о','к','а','!',},
};
System.Console.WriteLine($"Итоговая строка: \"{ConcatMatrix(matrix1)}\"  ");

int m = Input("Введите кол-во строк: "),
    n = Input("Введите кол-во стобцов: ");

char[,] matrix2 = Getmatrix(m, n, 32, 255);


PrintMatrix(matrix2);
System.Console.WriteLine($"Итоговая строка: \"{ConcatMatrix(matrix2)}\"  ");


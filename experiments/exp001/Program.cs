// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива. Под удалением понимается 
// создание нового двумерного массива без строки и столбца

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] Getmatrix(int len1, int len2, int a, int b)
{
  int[,] matrix = new int[len1, len2];
  b++;
  // Генерировать будем до b включительно 
  Random rand = new Random();
  for (int i = 0; i < len1; i++)
  {
    for (int j = 0; j < len2; j++)
    {
      matrix[i, j] = rand.Next(a, b);
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

int[] KoordinatyMin(int[,] arr1, int len1, int len2)
{
  int[] Koordinaty = new int[3] { arr1[0, 0], 0, 0 };
  for (int i = 0; i < len1; i++)
  {
    for (int j = 0; j < len2; j++)
    {
      if (arr1[i, j] < Koordinaty[0])
      {
        Koordinaty[0] = arr1[i, j];
        Koordinaty[1] = i;
        Koordinaty[2] = j;
        // System.Console.Write(Koordinaty[0]);
        // System.Console.Write(Koordinaty[1]);
        // System.Console.Write(Koordinaty[2]);
        // System.Console.WriteLine();
      }
    }
  }

  return Koordinaty;
}

int[,] ChangeMatrix(int[,] arr2, int[] arr3, int len1, int len2)
{
  int[,] change = new int[len1 - 1, len2 - 1];
  int a = 0;
  int b = 0;
  for (int i = 0; i < len1; i++)
  {
    if (i == arr3[1]) continue;
    b = 0;
    for (int j = 0; j < len2; j++)
    {
      if (j == arr3[2]) continue;
      change[a, b] = arr2[i, j];
      b++;
    }
    a++;
  }
  return change;
}

int m = Input("Введите количество строк: "), n = Input("Введите количество столбцов: ");
int[,] arr = Getmatrix(m, n, 0, 99);
System.Console.WriteLine("Изначальная матрица");
PrintMatrix(arr);
int[] min = KoordinatyMin(arr, m, n);
System.Console.WriteLine($"Мин элемент {min[0]}  координаты {min[1]} : {min[2]}");
int[,] array = ChangeMatrix(arr, min, m, n);

System.Console.WriteLine("Измененная матрица");
PrintMatrix(array);
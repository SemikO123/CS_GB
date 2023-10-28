// Напишите программу для работы с массивом вещественных чисел.

// Реализуйте класс ArrayOperations, который содержит следующие статические методы:

// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.

// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.

// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.

// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.

static double FindMax(double[] array)
{
  double max = array[0];
  foreach (double el in array)
  {
    if (el > max) max = el;
  }
  return max;
}

static double FindMin(double[] array)
{
  double min = array[0];
  foreach (double el in array)
  {
    if (el < min) min = el;
  }
  return min;
}

static double CalcDifferenceBetweenMaxMin(double[] array)
{

  return FindMax(array) - FindMin(array);
}

static void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write("{0:f2}" + ((i < array.Length - 1) ? "\t" : ""), array[i]);
  }
  Console.WriteLine();
}

double[] array = new double[] { 3, 7.4, 22.3, 2, 78 };

Console.WriteLine("Массив:");
PrintArray(array);
double diff = CalcDifferenceBetweenMaxMin(array);
Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
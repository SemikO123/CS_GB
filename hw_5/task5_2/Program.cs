static int SumOddElements(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i += 2)
  {
    sum += array[i];
  }
  return sum;
}

static void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + ((i < array.Length - 1) ? "\t" : ""));
  }
  Console.WriteLine();
}

int[] array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };

PrintArray(array);
int sumOdd = SumOddElements(array);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
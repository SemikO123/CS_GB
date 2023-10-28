static int CountEvenElements(int[] array)
{
  int count = 0;
  foreach (int el in array)
    if (el % 2 == 0) count++;
  return count;
}

static void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + ((i < array.Length - 1) ? "\t" : ""));
  }
  Console.WriteLine();
}

int[] array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };

Console.WriteLine("Массив:");
PrintArray(array);
int evenCount = CountEvenElements(array);
Console.WriteLine($"Количество четных элементов: {evenCount}");
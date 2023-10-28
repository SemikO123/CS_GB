// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int len, int a, int b)
{
  int[] array = new int[len];
  b++; // Генерировать будем до b включительно
  Random rand = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(a, b);
  }
  return array;
}

void PrintArray(int[] array)
{
  foreach (int num in array)
  {
    // System.Console.Write($"{num} ");
    System.Console.Write("{0, 4}", num);
  }
  System.Console.WriteLine();
}

int[] GetProduct(int[] array)
{
  int len = array.Length / 2 + array.Length % 2;

  int[] prod = new int[len];
  int lastInd = array.Length - 1;
  for (int i = 0; i < len; i++)
  {
    prod[i] = array[i] * array[lastInd - i];
  }
  if (array.Length % 2 == 1)
    prod[len - 1] = array[len - 1];

  return prod;
}

Console.Clear();

int[] arr = GetArray(31, 1, 20);
PrintArray(arr);
// System.Console.WriteLine("Произведения элементов: ");
PrintArray(GetProduct(arr));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// ТАК КАК УСЛОВИЕ ЗАДАЧИ КРАЙНЕ РАСПЛЫВЧАТОЕ, А ПРИМЕР РЕЗУЛЬТАТА В ПРИНЦИПЕ ЕМУ ПРОТИВОРЕЧИТ
// ТО ДЕЛАТЬ БУДЕМ МАССИВ ВВЕДЕННОЙ ДЛИНЫ С РАНДОМНЫМИ ВЕЛИЧИНАМИ В ДИАПАЗОНЕ ЗАДАННОМ ПОЛЛЬЗОВАТЕЛЕМ

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[] GetArray(int len, int a, int b)
{
  int[] array = new int[len];
  b++; // Генерировать будем до b включительно
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(a, b);
  }
  return array;
}

void PrintArray(int[] array)
{
  foreach (int num in array)
  {
    System.Console.Write($"{num} ");
  }
  System.Console.WriteLine();
}

int len = Input("Input array length: "),
    left = Input("input left border of random: "),
    right = Input("input right border of random: ");

int[] arr = GetArray(len, left, right);
PrintArray(arr);




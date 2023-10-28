// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
    System.Console.Write($"{num} ");
  }
  System.Console.WriteLine();
}

// int GetSumOfPositive(int[] array)
// {
//   int sum = 0;
//   foreach (int elem in array)
//     if (elem > 0) sum += elem;
//   return sum;
// }

// int GetSumOfNegative(int[] array)
// {
//   int sum = 0;
//   foreach (int elem in array)
//     if (elem < 0) sum += elem;
//   return sum;
// }

int[] arr = GetArray(12, -9, 9);
PrintArray(arr);

// System.Console.WriteLine($"Summ of positive = {GetSumOfPositive(arr)}\n"
//                         + $"Summ of negative = {GetSumOfNegative(arr)}");


// пробую возвращаемые параметры
void GetSums(int[] array, out int sumP, out int sumN) 
{
  sumP = 0;
  sumN = 0;
  foreach (int elem in array)
    if (elem < 0) sumN += elem;
    else sumP += elem;
}


int sumP = 0, sumN = 0;
GetSums(arr, out sumP, out sumN); 

System.Console.WriteLine($"Summ of positive = {sumP}\n"
                        + $"Summ of negative = {sumN}");
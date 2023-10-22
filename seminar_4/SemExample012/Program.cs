// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 2);
  }
}

void PrintArray(int[] array)
{
  foreach (int num in array)
  {
    System.Console.Write($"{num} ");
  }
  System.Console.WriteLine();
}

int CountElements(int[] array, int num)
{
  int count = 0;
  foreach (int element in array)
  {
    if (element == num) count++;
  }
  return count;
}

int N = Input("Введите длину массива: ");
int[] arr = new int[N];

FillArray(arr);
PrintArray(arr);
System.Console.WriteLine($"Число единиц в массиве = {CountElements(arr, 1)}");


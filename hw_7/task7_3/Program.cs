// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

//В условии задачи не указано что является произвольным массивом поэтому будем генерировать его на рандом.

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void FillArray(int[] array, int a, int b, int i = 0)
{
  array[i] = new Random().Next(a, b);
  if (i < array.Length - 1) FillArray(array, a, b, i + 1);
}

void RecursivePrintArrayReverse(int[] array, int i = 0)
{
  if (i < array.Length - 1) RecursivePrintArrayReverse(array, i + 1);
  System.Console.Write($"{array[i]} ");
}

//Данная функция присутствует в коде для проверки корректности решения и не является частью домашнего задания
void PrintArray(int[] array)
{
  foreach (int num in array)
  {
    System.Console.Write($"{num} ");
  }
  System.Console.WriteLine();
}

int arrayLen = Input("Введите длину массива: ");
int[] randomArray = new int[arrayLen];

FillArray(randomArray, 0, 100); //Заполняем массив случайными величинами

System.Console.WriteLine("Случайный массив в прямом порядке:");
PrintArray(randomArray);
System.Console.WriteLine("Случайный массив в обратном порядке:");
RecursivePrintArrayReverse(randomArray);
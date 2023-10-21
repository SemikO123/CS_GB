
int[] arr = { 1, 5, 6, 7, 2, 3, 4, 5, 5, 6, 9, 0 };

void PrintArray(int[] array)
{
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    System.Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;

    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition]) minPosition = j;
    }

    int tmp= array[i];
    array[i] = array[minPosition];
    array[minPosition] = tmp;
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
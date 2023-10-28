// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++ )
//     arr[i] = new Random().Next();
// }

// void PrintArray(int[] arr)
// {
//     foreach (int item in arr)
//     Console.Write($"{item} ");
//     System.Console.WriteLine();
// }


// int[] array = new int[20];
// FillArray(array);
// PrintArray(array);
for (int i = 0; i < 10; i++)
{
  int count = 1;
  Random rand = new Random();
  int num = rand.Next();
  while (num > 999)
  {
    //System.Console.WriteLine(num);
    num = rand.Next();
    count++;
    //if (count % 1000 == 0) System.Console.WriteLine($"count = {count}");
  }

  System.Console.WriteLine($"count = {count}");
}


void FillArray(int[] collection)
{
  int length = collection.Length;
  int i = 0;
  while (i < length)
  {
    collection[i] = new Random().Next(1, 10);
    i++;
  }
}

void PrintArray(int[] collection)
{
  int length = collection.Length;
  int i = 0;
  while (i < length)
  {
    Console.Write(collection[i++] + " ");
  }
  Console.WriteLine();
}

int IndexOf(int[] collection, int find)
{
  int count = collection.Length;
  int i = 0;

  while(i < count)
  {
    if (collection[i] == find)
    {
      return i;
    }
    i++;
  }
  return -1;
}


int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
int find = 4;
int pos = IndexOf(arr, find);

Console.WriteLine("Position of " + find + " is " + pos);
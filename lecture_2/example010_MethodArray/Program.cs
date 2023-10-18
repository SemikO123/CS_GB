int[] arr = { 1, 2, 31, 4, 56, 34, 54, 66, 4 };

int n = arr.Length;

int find = 4;
int i = 0;
while (i < n)
{
  if (arr[i] == find)
  {
    Console.WriteLine(i);
    break; //прерывыает цикл
  }
  i++;
}
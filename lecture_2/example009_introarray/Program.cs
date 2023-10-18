// int Max(int a, int b, int c)
// {
//   int max = a;
//   if (b > max) max = b;
//   if (c > max) max = c;
//   return max;
// }

// int max1 = Max(arr[0], arr[1], arr[2]),
//     max2 = Max(arr[3], arr[4], arr[5]),
//     max3 = Max(arr[6], arr[7], arr[8]);

// int superMax = Max(max1, max2, max3);
// Console.WriteLine("Max = " + superMax);

int[] arr = { 1, 2, 223, 4, 487, 6, 7, 8, 9 };

int max = arr[0], i = 0;
while (i < arr.Length)
{
  if (arr[i] > max) max = arr[i];
  i++;
}

Console.WriteLine("max = " + max);


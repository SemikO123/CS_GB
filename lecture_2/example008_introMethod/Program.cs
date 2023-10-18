int Max(int a, int b, int c)
{
  int max = a;
  if (b > max) max = b;
  if (c > max) max = c;
  return max;
}


int a1 = 15, b1 = 21, c1 = 39,
    a2 = 13, b2 = 14, c2 = 233,
    a3 = 44, b3 = 1000, c3 = 45;

int max1 = Max(a1, b1, c1),
    max2 = Max(a2, b2, c2),
    max3 = Max(a3, b3, c3);

int superMax = Max(max1, max2, max3);
//int superMax = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine("Max = " + superMax);

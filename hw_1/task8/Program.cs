Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 2;
while (i <= n)
{
  Console.Write(i + (n - i > 1 ? ", " : ""));
  i += 2;
}
// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

Console.Write("Input 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3rd number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max = " + max);
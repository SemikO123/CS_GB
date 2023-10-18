// Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Input 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a < b) max = b;

Console.WriteLine("max = " + max);

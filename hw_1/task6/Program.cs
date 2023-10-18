// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0) Console.WriteLine("Yes");
else Console.WriteLine("No");
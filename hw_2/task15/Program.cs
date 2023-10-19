// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("input number : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 7)
{
  System.Console.WriteLine((num == 6 || num == 7) ? "Yes" : "No");
}
else System.Console.WriteLine("U must unput number from 1 to 7");
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("input number :");
int num = Convert.ToInt32(Console.ReadLine());

int digit = (num % 100) / 10;

System.Console.WriteLine("2nd digit of your numbres is " + digit);

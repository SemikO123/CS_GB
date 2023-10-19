// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);

int clipped = (num / 100) * 10 + (num % 10);

Console.WriteLine("Clipped version of " + num + " is " + clipped);
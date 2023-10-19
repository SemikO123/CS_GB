// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("input number :");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99){
  while (num > 999) num /= 10;
  System.Console.WriteLine("3rd digit is " + (num % 10));
}
else System.Console.WriteLine("the number doesn't have a 3rd digit");



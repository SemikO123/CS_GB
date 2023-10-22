// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

decimal Input(string message)
{
  System.Console.Write(message);
  decimal result = Convert.ToDecimal(Console.ReadLine());
  return result;
}

int CountDigits(decimal num)
{
  int count = (num >= 0 && num < 1) ? 1 : 0; // учитываем нолик
  decimal tmp = num; // запоминаем исходное значение числа

  //считаем все цифры перед запятой
  while (tmp >= 1)
  {
    tmp /= 10;
    count++;
    //System.Console.WriteLine($"tmp = {tmp}");
  }

  tmp = num;
  // считаем все цифры после запятой
  while (tmp % 1 > 0)
  {
    tmp *= 10;
    count++;
    //System.Console.WriteLine($"tmp = {tmp}");
  }

  return count;
}

decimal number = Input("Введите число: ");
System.Console.WriteLine($"count of digits in {number} = {CountDigits(number)}");

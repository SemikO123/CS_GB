// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

decimal Input(string message)
{
  System.Console.Write(message);
  decimal result = Convert.ToDecimal(Console.ReadLine());
  return result;
}

int GetSum(decimal num)
{
  long sum = 0;
  //Сдвигаем все значащие цифры влево от запятой
  while (num % 1 > 0)
  {
    num *= 10;
  }

  // Дальше работаем как с обычным целым
  long intNumber = Convert.ToInt64(num);
  while(intNumber > 0)
  {
    sum += intNumber % 10;
    intNumber /= 10;
  }
  return Convert.ToInt32(sum);
}

decimal number = Input("Input number: ");
System.Console.WriteLine($"Sum of digits in {number} = {GetSum(number)}");

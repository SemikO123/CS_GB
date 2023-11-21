// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// Указание
// Использовать рекурсию.

// Пример
// 123 => 6
// 63 => 9

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int SummOfDigits(int n)
{
  // if (n == 0) return 0;
  // return (n % 10) + SummOfDigits( n / 10);
  return n != 0 ? (n % 10) + SummOfDigits(n / 10) : 0;
}

int n = Input("Введите число: ");
System.Console.WriteLine($"Сумма чисело числа {n} = {SummOfDigits(n)}");
// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int N = Input("Введите пятизначное число: ");
int size = 5;

//Для удобства проверки распихиваем цифры по массиву
int[] digits = new int[size];
for (int i = size - 1; i >= 0; --i)
{
  digits[i] = N % 10;
  N /= 10;
}

//проверяем является ли число паллиндромом
bool isPol = true;
for (int i = 0; i < size / 2; i++)
{
  if (digits[i] != digits[size - i - 1])
  {
    isPol = false;
    break;
  }
}

System.Console.WriteLine(isPol ? "yes" : "no");
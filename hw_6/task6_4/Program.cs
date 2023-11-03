// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

//Все операции надо строкой предлагаю реализовывать без встроеных методов.

string Input(string message)
{
  System.Console.Write(message);
  string result = Console.ReadLine()!; // восклицательный знак чтобы не ругался на возможный NULL
  return result;
}


string Reverse(string str)
{
  string res = string.Empty;
  for (int i = str.Length - 1; i >= 0; i--)
  {
    res += str[i];
  }
  return res;
}


string ReverseOrderedString(string str)
{
  string res = string.Empty; // Итоговая строка
  string currentWord = string.Empty; // Текущее слово
  // Идем по массиву с конца в начало, назодим слова до пробела после чего разворачиваем их и плюсуем к итоговой строке.
  for (int i = str.Length - 1; i >= 0; i--) 
  {
    if (str[i] != ' ') currentWord += str[i]; 
    else
    {
      res += Reverse(currentWord) + ' ';
      currentWord = string.Empty;
    }
  }
  res += Reverse(currentWord);

  return res;
}


//С использование метода Split
string ReverseOrderedString2(string str)
{
  string res = string.Empty;
  string[] words = str.Split(new char[]{' '});
  for (int i = words.Length - 1; i > 0; i--)
  {
    res += words[i] + ' ';
  }
  res += words[0];
  return res;
}

string str = Input("Введите строку: ");
System.Console.WriteLine(ReverseOrderedString(str));
System.Console.WriteLine(ReverseOrderedString2(str));
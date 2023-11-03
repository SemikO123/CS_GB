// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

//P.S Строку можно генерировать самому из рандомных кодов ASCII, можно вводить с клавиатуры, можно захардкодить.
//Метод ToLower напишем сами чтобы программа занимала больше 3-х строк.

using System.Xml.XPath;

string Input(string message)
{
  System.Console.Write(message);
  string result = Console.ReadLine()!; // восклицательный знак чтобы не ругался на возможный NULL
  return result;
}

//Символы A-Z лежат в диапазоне 65-90, а сиволы a-z в диапазоне 97-122 => чтобы перевести сивол в нижний регистр достаточно увеличить его код на 32.
string ToLower(string str)
{
  string result = string.Empty;
  for (int i = 0; i < str.Length; i++)
  {
    if(str[i] >= 'A' && str[i] <= 'Z') result += (char)(str[i] + 32);
    else result +=str[i];
  }
  return result;
}

string str = Input("Введите строку: ");
System.Console.WriteLine(ToLower(str));
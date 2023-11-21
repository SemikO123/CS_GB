// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример

// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d
// Aa Bb Cc Dd Ee Ff Gg Hh Ii Jj Kk Ll Mm Nn Oo Pp Qq Rr Ss Tt Uu Vv Xx Yy Zz

// согл consonant letter,  глас vowel letter

using System.Reflection.Metadata;

string Input(string message)
{
  System.Console.Write(message);
  string result = Console.ReadLine()!;
  return result;
}

char[] consonantLetters = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z', };

bool isConsonant(char letter, int i = 0)
{
  if (i == consonantLetters.Length) return false;
  if (char.ToLower(letter) == consonantLetters[i]) return true;
  return isConsonant(letter, i + 1);
}

string onlyConsonantMustSurvive(string text, int i = 0)
{
  if (i == text.Length) return "";
  return (isConsonant(text[i]) ? text[i] : "") + onlyConsonantMustSurvive(text, i + 1);
}

string onlyConsonantMustSurvive2(string text)
{
  if (text == string.Empty) return "";
  return (isConsonant(text[0]) ? text[0] : "") + onlyConsonantMustSurvive2(text.Substring(1));
}

string text = Input("Input your text: ");
System.Console.WriteLine(onlyConsonantMustSurvive(text));
System.Console.WriteLine(onlyConsonantMustSurvive2(text));

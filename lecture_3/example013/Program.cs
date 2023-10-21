// Итак, задача. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;
  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
    result += (text[i] == oldValue) ? newValue : text[i];
  }
  return result;
}

text = Replace(text, ' ', '_');
text = Replace(text, 'к', 'К');
text = Replace(text, 'С', 'с');

System.Console.WriteLine(text);

Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 35, ya = 1, 
    xb = 1, yb = 20,
    xc = 70, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.Write("+");
Console.SetCursorPosition(xb, yb);
Console.Write("+");
Console.SetCursorPosition(xc, yc);
Console.Write("+");

int x = xa, y = yb;

int i = 0;
int count = 10000;
while (i < count)
{
  int what = new Random().Next(0,3);
  if (what == 0)
  {
    x = (x + xa) / 2;
    y = (y + ya) / 2;
  }

  if (what == 1)
  {
    x = (x + xb) / 2;
    y = (y + yb) / 2;
  }

  if (what == 2)
  {
    x = (x + xc) / 2;
    y = (y + yc) / 2;
  }
  Console.SetCursorPosition(x, y);
  Console.Write("+");
  i++;
}
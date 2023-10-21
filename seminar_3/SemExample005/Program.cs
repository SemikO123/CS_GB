// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Input(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void SearchQuarter(int x, int y)
{
  if (x == 0 || y == 0){
    System.Console.WriteLine("Bad Coordinates!");
    return;
  }
  int answer = 0;
  answer = (x > 0) ? ((y > 0) ? 1 : 4)
                    : ((y > 0) ? 2 : 3);
  System.Console.WriteLine("Your point in " + answer + " quarter");
}

int x = Input("Input X coordinate: "),
    y = Input("Input Y coordinate: ");
SearchQuarter(x, y);


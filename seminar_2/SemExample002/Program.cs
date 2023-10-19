// Напишите программу, которая будет принимать на вход два числа и выводить, является ли Первое кратно второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Input 1st number : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd number : ");
int num2 = Convert.ToInt32(Console.ReadLine());

int mod = num1 % num2;

Console.WriteLine(mod == 0 ? "Кратно" : ("Не кратно, остаток " + mod));


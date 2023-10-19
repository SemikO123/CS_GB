int num = new Random().Next(10, 100);

int dig1 = num / 10,
    dig2 = num % 10;

int max = dig1 > dig2 ? dig1: dig2;

Console.WriteLine("Max digit from number " + num + " is " + max);
Console.Write("Enter username: ");
string username = Console.ReadLine();

if (username.ToUpper() == "МАША")
{
  Console.WriteLine("Привет, булка");
}
else
{
  Console.WriteLine("Привет, " + username);
}
Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "игорь")
{
      Console.WriteLine("Ура, это же Игорь!");
}
else
{
      Console.Write("Привет, ");
      Console.WriteLine(username);
}     
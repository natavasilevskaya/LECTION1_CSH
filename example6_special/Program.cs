
Console.WriteLine("Введите имя пользователя: "); 
string username = Console.ReadLine(); // записываем в переменную имя пользователя

if (username.ToLower() == "ната")
{
    Console.WriteLine("Ура, это же Ната!");
}

if (username.ToLower() == "михаил")
{
    Console.WriteLine("Ну ты и пидр!");
}

else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
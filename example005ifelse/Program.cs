Console.WriteLine("введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура это же Маша");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}
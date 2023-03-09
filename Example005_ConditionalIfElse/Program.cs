Console.Write("Введите имя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")  //ToLower() и текст в кавычках в НИЖНЕМ регистре
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
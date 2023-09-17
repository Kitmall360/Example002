Console.Write("Введите Имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "катя")
{
    Console.WriteLine("Оо госпожа!!");
}
else
{
    Console.Write("Дарова, Холоп ");
    Console.WriteLine(username);
}
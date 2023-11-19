Console.WriteLine("введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Hello этоже Маша ");
}
else
{
    Console.Write("Ой иди ты, ТЫ не Маша это печально");
    Console.WriteLine(username);
}

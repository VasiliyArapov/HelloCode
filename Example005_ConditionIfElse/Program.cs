Console.Write("Input user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Great it's Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
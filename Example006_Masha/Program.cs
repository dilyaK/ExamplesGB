Console.WriteLine("Enter your name");
string username = Console.ReadLine();

if(username.ToLower() == "Jane")
{
    Console.WriteLine("Wow, it's Jane!");

}

else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
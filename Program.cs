using GreetingLib;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            var username = args[0];
            var message = GreetingGenerator.GenerateGreeting(username);

            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Please provide a username as an argument.");
        }
    }
}

using Foundational;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Command cmd_help = new Command("help", new Command[] {
            new Command("about"),
            new Command("command", new Command[] {
                new Command("help"),
                new Command("exit", new Command[] {
                    new Command("%d")
                }),
            })
        });

        Console.WriteLine(cmd_help);
    }
}

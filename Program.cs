using Foundational;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        LambdaCommand lcmd_help = new LambdaCommand("help",
            new LambdaCommand[] {
                new LambdaCommand("exit", (string[] args) =>
                {
                    int.TryParse(args[1], out int code);
                    Environment.Exit(code);
                    return 0;
                }),
                new LambdaCommand("about", (string[] args) =>
                {
                    Console.WriteLine("This subcommand outputs the information about about.");
                    return 0;
                }),
                new LambdaCommand("command", new LambdaCommand[] {
                    new LambdaCommand("help", (string[] args) =>
                    {
                        Console.WriteLine("A help subcommand outputs current help message.");
                        return 0;
                    }),
                    new LambdaCommand("exit", new LambdaCommand[] {
                        new LambdaCommand("%d", (string[] args) =>
                        {
                            return 0;
                        })
                    }, (string[] args) =>
                    {
                        Console.WriteLine("Exit exits the program in the exit using exitcode.");
                        return 0;
                    }),
                }, (string[] args) =>
                {
                    Console.WriteLine("Get helps for each supported command.");
                    return 0;
                })
            }, (string[] args) =>
            {
                Console.WriteLine("This is a message of help.");
                return 0;
            }
        );

        Console.WriteLine(lcmd_help);
    }
}

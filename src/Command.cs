namespace Foundational;

class Command : Executable
{
    private readonly string identifier = "";
    private readonly Command[] subcommands = [];

    public Command(string identifier, Command[] subcommands)
    {
        if (identifier == null)
        {
            return;
        }

        this.identifier = identifier;
        this.subcommands = subcommands;
    }

    public Command(string identifier)
    {
        new Command(identifier, []);
    }

    public string GetIdentifier()
    {
        return this.identifier;
    }

    public Command[] GetSubcommands()
    {
        return this.subcommands;
    }

    public int Execute(string[] args, string[] envs)
    {
        return 0;
    }

    public int Execute(string[] args)
    {
        return 0;
    }

    public int Execute()
    {
        return 0;
    }

}
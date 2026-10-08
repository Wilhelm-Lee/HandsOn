namespace Foundational;

// dotnet run --aplle 
abstract class AbstractCommand : Executable
{
    public string identifier { get; protected set; } = "";
    public AbstractCommand[] subcommands { get; protected set; } = [];

    public AbstractCommand(string identifier, AbstractCommand[] subcommands)
    {
        if (identifier == null)
        {
            return;
        }

        this.identifier = identifier;
        this.subcommands = subcommands;
    }

    public AbstractCommand(string identifier)
    {
        if (identifier == null)
        {
            return;
        }

        this.identifier = identifier;
        this.subcommands = [];
    }

    public int Execute(string[] args)
    {
        return 0;
    }
}

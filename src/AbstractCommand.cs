namespace Foundational;

abstract class AbstractCommand
{
    protected string identifier = "";
    protected AbstractCommand[] subcommands = [];

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

    public string GetIdentifier()
    {
        return this.identifier;
    }

    public AbstractCommand[] GetSubcommands()
    {
        return this.subcommands;
    }
}
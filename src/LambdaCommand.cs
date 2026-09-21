namespace Foundational;

class LambdaCommand : AbstractCommand
{
    private readonly Func<string[], int> func = (string[] args) => 0;

    public LambdaCommand(
        string identifier,
        LambdaCommand[] subcommands,
        Func<string[], int> func
    ) : base(identifier, subcommands)
    {
        if (identifier == null)
        {
            return;
        }

        this.identifier = identifier;
        this.subcommands = subcommands;

        if (func == null)
        {
            return;
        }

        this.func = func;
    }

    public LambdaCommand(
        string identifier,
        Func<string[], int> func
    ) : base(identifier)
    {
        if (func == null)
        {
            return;
        }

        this.func = func;
    }

    public override int Execute(string[] args)
    {
        return this.func(args);
    }
}

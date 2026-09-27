namespace Foundational;

class LambdaCommand : AbstractCommand
{
    // private readonly Func<string[], int> func = (string[] args) => 0;
    private readonly Func<string[], int> func;

    public LambdaCommand(
        string identifier,
        LambdaCommand[] subcommands,
        Func<string[], int> func
    ) : base(identifier, subcommands)
    {
	// Constructor must initialize field
        this.func = func;
	
        if (func == null)
        {
            return;
        }

        // this.func = func;
    }

    public LambdaCommand(
        string identifier,
        Func<string[], int> func
    ) : base(identifier)
    {
	// Constructor must initialize field
	this.func = func;
        new LambdaCommand(identifier, [], func);
    }

    public override int Execute(string[] args)
    {
        // return this.func(args);
	
	// If this.func == null return 0; else return this.func(args)
        return this.func?.Invoke(args) ?? 0;
    }
}

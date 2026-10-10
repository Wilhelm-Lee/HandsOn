namespace HandsOn;


public class DiverseCommand : Command, Executable
{

    private Func<int>? ExecutesDele = null;


    public DiverseCommand(string indentifier, Command[] subCommand) : base(indentifier, subCommand)
    {
    }

    protected override DiverseCommand[] DeepCopy(Command[] commands)
    {
        DiverseCommand[] copy = new DiverseCommand[commands.Length];

        int i = 0;
        foreach (var command in commands)
        {
            copy[i] = new DiverseCommand(command.GetIndentifier(),
                command.GetSubCommands());
            i++;
        }

        return copy;
    }

        
    public void SetExcute(Func<int>? execute)
    {
        this.ExecutesDele = execute;
    }


    public override int Execute()
    {
        if ( this.ExecutesDele == null )
            throw new UnimplementedException();
        return this.ExecutesDele();
    }
}

namespace HandsOn;

interface Executable
{
    int Execute();
}

public class Command : Executable
{
    private Func<int> ExecutesDele = () => 0;
    private string Indentifier;
    private Command[] SubCommands;

    private Exception UnimplementedException =
        new Exception("not  implement Execute command");

    public Command(string indentifier, Command[] commands)
    {
        if (!CheckIndentifier(indentifier))
        {
            throw new InvalidIdentifier();
        }

        this.Indentifier = (string)indentifier.Clone();
        this.SubCommands = Command.DeepCopy(commands);
    }

    public bool CheckIndentifier(string indentifier)
    {
        if (indentifier == "su" || indentifier == "sudo")
        {
            return false;
        }

        return true;
    }

    public string GetterIndentifier()
    {
        return this.Indentifier;
    }

    public void SetterIndentider(string indentifier)
    {
        if (!CheckIndentifier(indentifier))
        {
            throw new InvalidIdentifier();
        }

        this.Indentifier = (string)indentifier.Clone();
    }

    public Command[] GetterSubCommands()
    {
        return this.SubCommands;
    }

    public void SetterSubCommands(Command[] subcommands)
    {
        this.SubCommands = Command.DeepCopy(subcommands);
    }

    private static Command[] DeepCopy(Command[] commands)
    {
        Command[] copy = new Command[commands.Length];

        int i = 0;
        foreach (var command in commands)
        {
            copy[i] = new Command(command.GetterIndentifier(),
                command.GetterSubCommands());
            i++;
        }

        return copy;
    }

    public void SetExcute(Func<int> execute)
    {
        this.ExecutesDele = execute;
    }

    public int Execute()
    {
        return this.ExecutesDele();
    }
}
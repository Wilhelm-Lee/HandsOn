namespace HandsOn;




public abstract class Command : Executable
{
    
    protected string Indentifier;
    protected Command[] SubCommands;



    public Command(string indentifier, Command[] commands)
    {
        if (!CheckIndentifier(indentifier))
        {
            throw new InvalidIdentifier();
        }

        this.Indentifier = (string)indentifier.Clone();
        this.SubCommands = DeepCopy(commands);
    }



    public bool CheckIndentifier(string indentifier)
    {
        if (indentifier == "su" || indentifier == "sudo")
        {
            return false;
        }

        return true;
    }


    // -----------------------------------------
    // Getter Setter for field
    public string GetIndentifier()
    {
        return (string)this.Indentifier.Clone();
    }

    public Command[] GetSubCommands()
    {
        return DeepCopy(this.SubCommands);
    }



    public void SetIndentider(string indentifier)
    {
        if (!CheckIndentifier(indentifier))
        {
            throw new InvalidIdentifier();
        }

        this.Indentifier = (string)indentifier.Clone();
    }

    public void SetSubCommands(Command[] subcommands)
    {
        this.SubCommands = DeepCopy(subcommands);
    }

    // Getter Setter for field
    // -----------------------------------------



    // abstract method
    protected abstract Command[] DeepCopy(Command[] commands);


    public abstract int Execute();

}

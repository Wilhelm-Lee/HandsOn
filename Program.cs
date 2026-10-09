namespace HandsOn;

internal static class Program
{
    private static int Main()
    {
        /* Items marked with ! ahead are deemed completed.  Requirement: Finish the modularisation and fix the typos. */

        /* ! Write an abstract class Command including an identifier and an array of subcommands with an abstract method for interface Executable method. */
        
        /* ! Write the constructors of the class Command upon both members. */
        
        /* 1/2! Write a Direct-Reference-Modification safe Getter and Setter for both members. */
        
        /* ! Write an interface for class Command's execution. */
        
        /* Write a diverse class to class Command to implement the interface. */

        /* ! Write Exceptions for InvalidIdentifier. */

        /* Use UnimplementedException for unimplemented interface method declarations. */

        var ls = new Command("ls", [new Command("", [])]);
        Console.WriteLine(ls.GetterIndentifier());

        ls.SetExcute(() => 255);
       
        Console.WriteLine(ls.Execute());
        return 0;
    }
}

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

        // normal command
        var ls = new DiverseCommand("ls", [new DiverseCommand("", [])]);

        ls.SetExcute(() => 255);
       
        Console.WriteLine(ls.GetIndentifier()
                + " command return: "+
                ls.Execute());


        Console.WriteLine("--------------");
        

        // no implement execute method(interface)
        try {
            var file = new DiverseCommand("file", [new DiverseCommand("", [])]);
            Console.WriteLine(file.Execute());
        } catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }


        // "su" is invalid Command identifier
        try {
            var file = new DiverseCommand("su", [new DiverseCommand("", [])]);
            Console.WriteLine(file.Execute());
        } catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        return 0;
    }
}

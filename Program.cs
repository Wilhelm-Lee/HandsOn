namespace HandsOn;

internal static class Program
{
    private static void Main()
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
    //     var ls = new DiverseCommand("ls", [new DiverseCommand("", [])]);
    //
    //     ls.SetExcute(() => 255);
    //
    //     Console.WriteLine(ls.GetIndentifier()
    //             + " command return: "+
    //             ls.Execute());
    //
    //
    //     Console.WriteLine("--------------");
    //
    //
    //     // no implement execute method(interface)
    //     try {
    //         var file = new DiverseCommand("file", [new DiverseCommand("", [])]);
    //         Console.WriteLine(file.Execute());
    //     } catch (Exception e)
    //     {
    //         Console.WriteLine($"Error: {e.Message}");
    //     }
    //
    //
    //     // "su" is invalid Command identifier
    //     try {
    //         var file = new DiverseCommand("su", [new DiverseCommand("", [])]);
    //         Console.WriteLine(file.Execute());
    //     } catch (Exception e)
    //     {
    //         Console.WriteLine($"Error: {e.Message}");
    //     }
    //
    //     return 0;
    // }



        Song song1 = new Song("11111", "~/Music/song1.m4a", "song1", 100);
        Song song2 = new Song("11112", "~/Music/song2.m4a", "song2", 100);
        Song song3 = new Song("11113" ,"~/Music/song3.m4a", "song3", 100);
        Song song4 = new Song("11114" ,"~/Music/song4.m4a", "song4", 100);
        Song song5 = new Song("11115" ,"~/Music/song5.m4a", "song5", 100);

        // Console.WriteLine(song1.GetAbsolutePath());
        // Console.WriteLine(song1.GetSongName());
        // Console.WriteLine(song1.GetSongLength());

        BackSongs backSongs = new([song1, song2, song3]);

        backSongs.Add(song4);
        backSongs.Add(song5);
        
        // backSongs.show();
        // backSongs.showHash();



        // check Add & Remove method
        Playlist nature_playlist = new([], backSongs);
        nature_playlist.Add("11111");
        nature_playlist.Add("11112");
        nature_playlist.Add("11111");

        nature_playlist.show();
        
        Console.WriteLine("\n-----------------------\n");

        nature_playlist.Remove("11112");
        nature_playlist.Remove("11113");


        nature_playlist.show();





        SongPlayer musciPlayer = new();
        musciPlayer.Play(song1);


        Console.WriteLine("\n-----------------------\n");


        // song6 same song5 in metadata, but actually different
        // Song song6 = new Song("11116", "~/Music/song5.m4a", "song5", 100);
        // nature_playlist.Add(song6);
        // nature_playlist.show();
        // nature_playlist.Remove(song6);
        //
        // Console.WriteLine("\n-----------------------\n");
        //
        //
        // // song7 same song5, but different reference
        // Song song7 = song5;
        // nature_playlist.Add(song7);
        // nature_playlist.show();
        // Console.WriteLine(song7.GetHashCode());
        // Console.WriteLine(song5.GetHashCode());
    }
}

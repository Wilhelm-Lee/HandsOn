using System;
using System.Runtime.InteropServices;

namespace HandsOn;

internal static class Program
{
    private static int Main()
    {
        Console.WriteLine("Hello, world!");

        // var indent = new Individual(10);
        //
        // indent.PrintAge();
        // indent.SetAge(20);
        // indent.PrintAge();

        // Person li = new Person(12, HandsOn.Personality.TRADITIONAL);
        // Person mo = new Person(12, HandsOn.Personality.NOVEL);
        //
        // li.HandShake(mo);
        //
        // li.Jump();
        // mo.Talk();

		

    // Create an interface that declares:
    //   1. ChangeMood(Mood newMood)
    //   2. Speak(string content)
    // Create an abstract class that is implementing a interface while keeping a method abstract.
    //   int walkedMeters;
    //   abstract Walk(int meters)
    // Create a class that inherits the abstract class while implementing a interface.
	



    	// Create the instance, call Walk, ChangeMood and Speak
        var li = new WalkerPerson(Mood.CONFIDENT);
        li.Walk(30);
        li.ChangeMood(Mood.INSIGHTFUL);
        li.Speak("How you doing?");

        return 0;
    }
}

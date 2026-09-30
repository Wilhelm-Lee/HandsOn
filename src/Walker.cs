using System;

namespace HandsOn;

enum Mood
{
    DELIGHTED,
    INSIGHTFUL,
    UNGROUNDED,
    NERVOUS,
    MOCKING,
    CONFIDENT
};

// Create an interface that declares:
//   1. ChangeMood(Mood newMood)
//   2. Speak(string content)
interface Express
{
    void ChangeMood(Mood newMood);
    void Speak(string content);
}

// Create an abstract class that is implementing a interface while keeping a method abstract.
//   int walkedMeters;
//   abstract Walk(int meters)
abstract class Walker : Express
{
    protected int walkedMerters = 0;

    public abstract void Walk(int meters);
    
    public abstract void ChangeMood(Mood newMood);
    public abstract void Speak(string content);
}




// Create a class that inherits the abstract class while implementing a interface.
class WalkerPerson : Walker
{
    // Field
    private Mood mood;


    // Constructor
    public WalkerPerson(Mood mood)
    {
        this.mood = mood;
    }

    
    // Method
    public override void Walk(int meters)
    {
        this.walkedMerters = meters;
        Console.WriteLine($"this walker people is walking {meters}m");
    }


    // ChangeMood Speak method interfalce implement
    public override void ChangeMood(Mood newMood)
    {
        this.mood = newMood;
        Console.WriteLine($"this walker people mood is {this.mood}");
    }

    public override void Speak(string content)
    {
        Console.WriteLine($"{content}");
    }

}

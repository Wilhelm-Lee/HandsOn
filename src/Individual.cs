using System; // Dependencies

namespace HandsOn;

interface Actionable
{
    public void Jump();
    public void Talk();
}

abstract class Individual : Actionable
{
    public string name { get; private set; } = "John Doe";
    public int age { get; private set; } = 0;
    protected Individual[] friends = [];

    public Individual(int age)
    {
        this.age = age;
    }

    // count = newValue;
    public void SetAge(int newValue)
    {
        age = newValue;
    }


    // <return> <identifier>(<parameters...>) { <definition> }

    // cw counter
    public void PrintAge()
    {
        Console.WriteLine($"{age}");
    }

    public void AddFriends(Individual[] newFriends)
    {
        int oldnumber = this.friends.Length;
        int newnumber = newFriends.Length;
        Individual[] friendsArray = new Individual[oldnumber + newnumber];

        for (int i = 0; i < oldnumber; i++)
        {
            friendsArray[i] = this.friends[i];
        }

        for (int i = oldnumber; i < oldnumber + newnumber; i++)
        {
            friendsArray[i] = newFriends[i];
        }

        this.friends = friendsArray;
    }

    public void Jump()
    {
        Console.WriteLine($"{this.name} Jumps!");
    }

    public void Talk()
    {
        Console.WriteLine($"{this.name} Talks!");
    }

    public abstract void HandShake(Individual another);
}

enum Personality
{
    TRADITIONAL,
    AGGRESSIVE,
    MODERATE,
    FOUND,
    NOVEL
};

// enum Mood
// {
//     DELIGHTED,
//     INSIGHTFUL,
//     UNGROUNDED,
//     NERVOUS,
//     MOCKING,
//     CONFIDENT
// };

class Person : Individual
{
    private Personality personality;

    public Person(int age, Personality personality) : base(age)
    {
        this.personality = personality;
    }

    public override void HandShake(Individual another)
    {
        //throw new NotImplementedException();
        // protect? anthoer.age 
        Console.WriteLine($"Handshake with {another.name} {another.age}");
    }
}

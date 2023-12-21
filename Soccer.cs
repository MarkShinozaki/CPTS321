using System;
using System.Collections.Generic;

public class SoccerPlayer
{
    public string Name { get; set; }
    public int JerseyNumber { get; set; }

    // 1. What would make sense to have here? 
    // Hint: Maybe something to handle the player's actions?
    
    // 2. How do these Violate SRP?
    // Hint: by handling 1. above, you can refactor these methods to not violate SRP? 
    public void ScoreGoal()
    {
        Console.WriteLine($"{Name} scored a goal!");
    }

    // 2. 
    public void Defend()
    {
        Console.WriteLine($"{Name} is defending.");
    }

    // 2. 
    public void Celebrate()
    {
        Console.WriteLine($"{Name} is celebrating!");
    }

    // 3. How can you refactor this to not violate OCP?
    // Hint: Should 'SoccerPlayer' class be closed for modification?
    public void PlayGame(List<Action> actions)
    {
        foreach (var action in actions)
        {
            action.Invoke();
        }
    }
}

class Program
{
    static void Main()
    {
        SoccerPlayer player1 = new SoccerPlayer { Name = "John", JerseyNumber = 10 };

        List<Action> player1Actions = new List<Action>
        {
            // 4. Violates OCP
            // Hint: If we added a new type of action, would that require modifying 'SoccerGame' 
            // or 'SoccerPlayer'? 
            () => player1.Defend(),
            () => player1.ScoreGoal(),
            () => player1.Celebrate()
        };

        player1.PlayGame(player1Actions);
    }
}




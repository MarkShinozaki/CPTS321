using System;
using System.Collections.Generic;

public class SoccerPlayer
{
    public string Name { get; set; }
    public int JerseyNumber { get; set; }
}

// A. Interface for player actions (SRP)
public interface IPlayerAction
{
    void PerformAction(SoccerPlayer player);
}

// A. Scorer class implementing the action interface (SRP)
public class Scorer : IPlayerAction
{
    public void PerformAction(SoccerPlayer player)
    {
        Console.WriteLine($"{player.Name} scored a goal!");
    }
}

// A. Defender class implementing the action interface (SRP)
public class Defender : IPlayerAction
{
    public void PerformAction(SoccerPlayer player)
    {
        Console.WriteLine($"{player.Name} is defending.");
    }
}

// A. Celebrator class implementing the action interface (SRP)
public class Celebrator : IPlayerAction
{
    public void PerformAction(SoccerPlayer player)
    {
        Console.WriteLine($"{player.Name} is celebrating!");
    }
}

// PlayGame method now accepts a list of player actions (OCP)
public class SoccerGame
{
    public void PlayGame(SoccerPlayer player, List<IPlayerAction> actions)
    {
        foreach (var action in actions)
        {
            action.PerformAction(player);
        }
    }
}

class Program
{
    static void Main()
    {
        SoccerPlayer player1 = new SoccerPlayer { Name = "John", JerseyNumber = 10 };

        List<IPlayerAction> player1Actions = new List<IPlayerAction>
        {
            new Defender(),
            new Scorer(),
            new Celebrator()
        };

        SoccerGame soccerGame = new SoccerGame();
        soccerGame.PlayGame(player1, player1Actions);
    }
    // In this version, we are using a list of 'IPlayerAction' interfaces, 
    // Which are specific to player actions. Adding a new type of action
    // (implmenting the IPlayerAction interface) does not require any changes to
    // existing code. 
}

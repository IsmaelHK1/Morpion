namespace Morpion.Models;

public class TeamModel
{
    public TeamRed? teamRed { get; set; }
    public TeamBlue? teamBlue { get; set; }
}

public class TeamRed
{
    public int score { get; set; } = 0;
    public bool isTurn { get; set; } = false;
}

public class TeamBlue
{
    public int score { get; set; } = 0;
    public bool isTurn { get; set; } = false;
}
using System;

public class ScoreHandler
{
    public void GivePoint(Player player)
    {
        player.score += 1;
    }

    public void CheckIfPlayerWon(Player player)
    {
        if(player.score >= 5)
        {
            player.hasWon = true;
        }
    }
}
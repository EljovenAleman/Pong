using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandlerShould : MonoBehaviour
{
    [Test]
    public void Add_A_Point_To_Player_When_Ball_Crosses_Threshold()
    {
        //Given        
        Player player = new Player();
        ScoreHandler scoreHandler = new ScoreHandler();

        int expectedScore = 1;

        //When
        scoreHandler.GivePoint(player);

        //Then
        Assert.AreEqual(expectedScore, player.score);
    }

    [Test]
    public void Make_The_player_Win_When_At_5_Points()
    {
        //Given
        ScoreHandler scoreHandler = new ScoreHandler();
        Player player = new Player();
        int scoreNeededToWin = 5;

        //When
        for(int i = 0; i < scoreNeededToWin; i++)
        {
            scoreHandler.GivePoint(player);
        }

        scoreHandler.CheckIfPlayerWon(player);

        //Then
        Assert.IsTrue(player.hasWon);
        
    }
}

using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InMemoryScoreRepositoryShould
{
    [Test]
    public void Add_A_Point_To_A_Player_Using_Its_ID()
    {
        //Given
        Player player1 = new Player();        

        player1.Id = PlayerId.p1;

        int expectedP1Score = 1;
        int expectedP2Score = 0;

        IScoreRepository scoreRepository = new InMemoryScoreRepository();

        //When
        scoreRepository.AddPoint(PlayerId.p1);

        //Then
        Assert.AreEqual(expectedP1Score, scoreRepository.GetP1Score());
        Assert.AreEqual(expectedP2Score, scoreRepository.GetP2Score());
    }

    [Test]
    public void Add_Points_When_Score_Is_Not_0()
    {
        //Given
        Player player1 = new Player();
        Player player2 = new Player();

        player1.Id = PlayerId.p1;
        player2.Id = PlayerId.p2;

        int expectedP1Score = 3;
        int expectedP2Score = 2;

        IScoreRepository scoreRepository = new InMemoryScoreRepository();

        //When
        scoreRepository.AddPoint(player1.Id);
        scoreRepository.AddPoint(player1.Id);
        scoreRepository.AddPoint(player1.Id);

        scoreRepository.AddPoint(player2.Id);
        scoreRepository.AddPoint(player2.Id);

        //Then
        Assert.AreEqual(expectedP1Score, scoreRepository.GetP1Score());
        Assert.AreEqual(expectedP2Score, scoreRepository.GetP2Score());

    }
}

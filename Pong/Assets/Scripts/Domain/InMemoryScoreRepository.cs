using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InMemoryScoreRepository : IScoreRepository
{
    Dictionary<PlayerId, int> scores = new Dictionary<PlayerId, int>();

    public void AddPoint(PlayerId playerId)
    {
        if(scores.Count == 0)
        {
            scores.Add(PlayerId.p1, 0);
            scores.Add(PlayerId.p2, 0);
        }

        scores[playerId] += 1;
    }

    public int GetP1Score()
    {
        return scores[PlayerId.p1];
    }

    public int GetP2Score()
    {
        return scores[PlayerId.p2];
    }
}

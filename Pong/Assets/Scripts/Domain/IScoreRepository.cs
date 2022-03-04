using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScoreRepository
{
    void AddPoint(PlayerId playerId);
    int GetP1Score();
    int GetP2Score();
}

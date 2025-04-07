using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    public SimpleIntData scoreData;

    public void IncreaseScore(int amount)
    {
        scoreData.UpdateValue(amount);
    }
}

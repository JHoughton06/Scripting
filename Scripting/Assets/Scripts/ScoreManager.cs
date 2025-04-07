using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int value;
    
    // Update is called once per frame
    public void UpdateValue(int amount)
    {
        value += amount;
    }

    public void SetAmount(int amount)
    {
        value = amount;
    }
}

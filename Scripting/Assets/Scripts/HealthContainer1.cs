using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthContainer1 : MonoBehaviour
{
    public SimpleFloatData healthData;

    public void ReduceHealth(float amount)
    {
        float newHealth = Mathf.Clamp(healthData.value + amount, 0f, 1f);
        healthData.value = newHealth;
    }

}

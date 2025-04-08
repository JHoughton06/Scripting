using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterAnimation : MonoBehaviour
{
    public void DisableSelf()
    {
        gameObject.SetActive(false); // Or Destroy(gameObject);
    }
}


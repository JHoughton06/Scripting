using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterAnimation : MonoBehaviour
{
    public Animator animator;
    public string stateName = "Disappear";

    void Update()
    {
        AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
        if (info.IsName(stateName) && info.normalizedTime >= 1f)
        {
            // Animation is done
            gameObject.SetActive(false); // or Destroy(gameObject);
        }
    }
}

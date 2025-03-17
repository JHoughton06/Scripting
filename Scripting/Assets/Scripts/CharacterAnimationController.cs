using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
            StartCoroutine(ResetTriggerAfterTime("Jump", stateInfo.length)); // Reset after animation time
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("Hit");
            StartCoroutine(ResetTriggerAfterTime("Hit", stateInfo.length));
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
            StartCoroutine(ResetTriggerAfterTime("Fall", stateInfo.length));
        }
    }

    private System.Collections.IEnumerator ResetTriggerAfterTime(string triggerName, float delay)
    {
        yield return new WaitForSeconds(delay);
        animator.ResetTrigger(triggerName);
        animator.SetTrigger("Idle"); // Return to Idle
    }
}





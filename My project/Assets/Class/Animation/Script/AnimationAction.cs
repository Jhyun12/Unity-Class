using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;
    public void Dance()
    {
        animator.Play("Dance");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}

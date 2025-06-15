using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPicker : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("pickingUp");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("walking");
        }
    }

    public void PickingUpTrigger()
    {
        animator.SetTrigger("pickingUp");
    }
    public void BreathingIdleTrigger()
    {
        animator.SetTrigger("breathingIdle");
    }
    public void WalkingTrigger()
    {
        animator.SetTrigger("walking");
    }
    public void RunningTrigger()
    {
        animator.SetTrigger("running");
    }
    public void ThrowObjectTrigger()
    {
        animator.SetTrigger("throwObject");
    }
    public void LayingBreathlessTrigger()
    {
        animator.SetTrigger("layingBreathless");
    }
    public void DwarfIdleTrigger()
    {
        animator.SetTrigger("dwarfIdle");
    }
    public void CrouchIdleTrigger()
    {
        animator.SetTrigger("crouchIdle");
    }
}

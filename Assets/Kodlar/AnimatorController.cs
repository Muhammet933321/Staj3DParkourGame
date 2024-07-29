using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    [SerializeField] SUPERCharacterAIO Controller;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        AnimatorStateInfo StateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKey(KeyCode.Q) && animator.GetFloat("Speed") < 0.3f)
        {
            animator.SetBool("Dance", true);
            Controller.enableMovementControl = false;
            Controller.canJump = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && animator.GetFloat("Speed") < 0.3f)
        {
            if (StateInfo.IsName("Idle Walk Run Blend"))
            {
                animator.SetBool("Sitting", true);
                Controller.enableMovementControl = false;
                Controller.canJump = false;
            } 
            else if(StateInfo.IsName("Sitting"))
            {
                animator.SetBool("Sitting", false);
                Controller.enableMovementControl = true;
                Controller.canJump = true;

            }
        }
        else if(!animator.GetBool("Sitting"))
        {
            animator.SetBool("Dance", false);
            Controller.enableMovementControl = true;
            Controller.canJump = true;
        }

    }
}

using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    [SerializeField] SUPERCharacterAIO controller;

    void Start()
    {
        animator = GetComponent<Animator>();

    }
    void Update()
    {
        float Speed = animator.GetFloat("Speed");
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKey(KeyCode.F) && Speed < 0.5f && stateInfo.IsName("Idle Walk Run Blend"))
        {
            animator.SetBool("BackFlip", true);
            controller.enableMovementControl = false;
            controller.canJump = false;
        }
        else if(stateInfo.normalizedTime > 0.8f && stateInfo.IsName("BackFlip"))
        {
            controller.enableMovementControl = true;
            controller.canJump = true;
            animator.SetBool("BackFlip", false);
        }

        if (Input.GetKey(KeyCode.Q) && Speed < 0.5f)
        {
            if (stateInfo.IsName("SittingIle"))
            {
                animator.SetBool("Sitting", false);
                controller.enableMovementControl = true;
                controller.canJump = true;

            }
            else if (stateInfo.IsName("Idle Walk Run Blend"))
            {
                animator.SetBool("Sitting", true);
                controller.enableMovementControl = false;
                controller.canJump = false;
            }

        }

    }
}

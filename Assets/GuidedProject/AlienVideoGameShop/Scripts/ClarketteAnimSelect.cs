using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClarketteAnimSelect : StateMachineBehaviour
{
    //pick a random number each time you enter a new state to randomize anims
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("IdleSelect", Random.Range(1, 4));
        animator.SetInteger("StretchSelect", Random.Range(1, 4));
        animator.SetInteger("CheckSelect", Random.Range(1, 3));
        animator.SetInteger("BoredSelect", Random.Range(1, 3));
    }
}

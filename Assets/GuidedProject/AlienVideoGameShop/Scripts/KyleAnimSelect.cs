using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleAnimSelect : StateMachineBehaviour
{
    //pick a random number each time you enter a new state to randomize anims
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //idleSelect chooses 1 of 3 Idle Anims
        //ActionSelect chooses 1 of 4 Action Anims
        //GestureSelect chooses 1 of 5 Gesture Anims
        animator.SetInteger("IdleSelect", Random.Range(1, 4));
        animator.SetInteger("ActionSelect", Random.Range(1, 5));
        animator.SetInteger("GestureSelect", Random.Range(1, 6));
    }
}


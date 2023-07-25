using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideCustomerAnimSelect : StateMachineBehaviour
{
    //pick a random number when you enter a new state to randomize anims
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("SelectType", Random.Range(1, 4));
        animator.SetInteger("NodSelect", Random.Range(1, 5));
        animator.SetInteger("IdleSelect", Random.Range(1, 5));
        animator.SetInteger("ActionSelect", Random.Range(1, 4));
    }
}

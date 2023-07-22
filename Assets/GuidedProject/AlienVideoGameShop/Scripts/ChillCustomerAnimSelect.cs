using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChillCustomerAnimSelect : StateMachineBehaviour
{
    //pick a random number when you enter a new state to randomize anims
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("AnimSelect", Random.Range(1, 7));
    }
}

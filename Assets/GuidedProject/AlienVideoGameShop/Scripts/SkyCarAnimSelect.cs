using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyCarAnimSelect : StateMachineBehaviour
{
    //pick a random number when you enter a new state to randomize anims
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //AnimSelect chooses 1 of 3 Anims
        animator.SetInteger("AnimSelect", Random.Range(1, 7));
    }


}






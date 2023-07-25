using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideLDR_RobotAnimSelect : StateMachineBehaviour
{
    //pick a random number when you enter a new state to randomize anims
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("SelectType", Random.Range(1, 4));
        animator.SetInteger("TalkSelect", Random.Range(1, 6));
        animator.SetInteger("ArgueSelect", Random.Range(1, 6));
        animator.SetInteger("ActionSelect", Random.Range(1, 4));
    }
}

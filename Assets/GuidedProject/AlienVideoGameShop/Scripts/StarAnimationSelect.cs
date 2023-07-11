using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimationSelect : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("IdleSelect", Random.Range(1, 4));
    }
}

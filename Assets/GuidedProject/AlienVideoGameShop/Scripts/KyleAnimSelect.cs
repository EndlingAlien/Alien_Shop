using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleAnimSelect : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("IdleSelect", Random.Range(1, 4));
        animator.SetInteger("ActionSelect", Random.Range(1, 5));
        animator.SetInteger("GestureSelect", Random.Range(1, 6));
    }
}


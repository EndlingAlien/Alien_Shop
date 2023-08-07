using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClarkAnimSelect : StateMachineBehaviour
{

    // Pick a random number each time you enter a new state to randomize anims
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("LookBelowSelect", Random.Range(1, 2));
        animator.SetInteger("LookAboveSelect", Random.Range(1, 4));
        animator.SetInteger("StretchSelect", Random.Range(1, 3));
        animator.SetInteger("MusicSelect", Random.Range(1, 4));
    }
}


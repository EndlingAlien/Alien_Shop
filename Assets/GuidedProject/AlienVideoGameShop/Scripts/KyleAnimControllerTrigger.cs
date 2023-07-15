using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleAnimControllerTrigger : MonoBehaviour
{
    //Makes Kyle the Robot randomly dance when Key: D is pressed
    private Animator anim;
    private bool canDance = true;
    private float danceCooldown = 20f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //Cant spam the D key
        if (Input.GetKeyDown(KeyCode.D) && canDance)
        {
            anim.SetTrigger("Robot_Dance");
            canDance = false;
            StartCoroutine(EnableDanceCooldown());
        }
    }

    private IEnumerator EnableDanceCooldown()
    {
        yield return new WaitForSeconds(danceCooldown);
        canDance = true;
    }
}

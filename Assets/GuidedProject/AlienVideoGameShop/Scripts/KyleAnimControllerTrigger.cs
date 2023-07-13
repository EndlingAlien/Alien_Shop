using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleAnimControllerTrigger : MonoBehaviour
{
    private Animator anim;
    private bool canDance = true;
    private float danceCooldown = 20f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
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

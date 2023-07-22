using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSlow : MonoBehaviour
{
    public float rotationSpeed = 1f;

    void Update()
    {
        //rotate on y Axis then reset to 0 when y = 360/-360
        transform.Rotate(0f, rotationSpeed, 0f);

        if (transform.eulerAngles.y >= 360f || transform.eulerAngles.y <= -360f)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0f, transform.eulerAngles.z);
        } 

    }
}

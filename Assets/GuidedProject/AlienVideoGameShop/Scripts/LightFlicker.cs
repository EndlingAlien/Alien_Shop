using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float flickerInterval = 0.1f; // Time between flickers
    public float minActiveTime = 0.1f; // Minimum time the light stays active
    public float maxActiveTime = 0.5f; // Maximum time the light stays active

    public GameObject flickeringObject;
    private float nextFlickerTime;
    private bool isFlickering;

    private void Start()
    {
        
        isFlickering = false;
        SetNextFlickerTime();
    }

    private void Update()
    {
        

        if (Time.time >= nextFlickerTime)
        {
            if (isFlickering)
            {
                Debug.Log("light is off");
                flickeringObject.SetActive(false); // Deactivate the GameObject
                isFlickering = false;
                SetNextFlickerTime();
            }
            else
            {
                Debug.Log("light is on");
                flickeringObject.SetActive(true); // Activate the GameObject
                isFlickering = true;
                SetNextFlickerTime();
            }
        }
    }

    private void SetNextFlickerTime()
    {
        nextFlickerTime = Time.time + Random.Range(minActiveTime, maxActiveTime + flickerInterval);
        Debug.Log("Set new flicker time");
    }
}


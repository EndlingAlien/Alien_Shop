using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camOne;
    public GameObject camTwo;

    // Start is called before the first frame update
    void Start()
    {
        camOne.SetActive(true);
        camTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            camOne.SetActive(true);
            camTwo.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            camOne.SetActive(false);
            camTwo.SetActive(true);
        }
    }
}

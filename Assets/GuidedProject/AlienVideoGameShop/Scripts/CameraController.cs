using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camOne;
    public GameObject camTwo;
    public GameObject camThree;
    public GameObject camFour;
    public GameObject camFive;

    // Start is called before the first frame update
    void Start()
    {
        camOne.SetActive(true);
        camTwo.SetActive(false);
        camThree.SetActive(false);
        camFour.SetActive(false);
        camFive.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            camOne.SetActive(true);
            camTwo.SetActive(false);
            camThree.SetActive(false);
            camFour.SetActive(false);
            camFive.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            camOne.SetActive(false);
            camTwo.SetActive(true);
            camThree.SetActive(false);
            camFour.SetActive(false);
            camFive.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            camOne.SetActive(false);
            camTwo.SetActive(false);
            camThree.SetActive(true);
            camFour.SetActive(false);
            camFive.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            camOne.SetActive(false);
            camTwo.SetActive(false);
            camThree.SetActive(false);
            camFour.SetActive(true);
            camFive.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            camOne.SetActive(false);
            camTwo.SetActive(false);
            camThree.SetActive(false);
            camFour.SetActive(false);
            camFive.SetActive(true);
        }
    }
}

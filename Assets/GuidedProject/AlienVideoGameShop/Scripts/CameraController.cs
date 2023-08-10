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
    public GameObject camSix;

    private bool camLocation;
    private int camNum;

    //At the start make cam1 active
    void Start()
    {
        camOne.SetActive(true);
        camTwo.SetActive(false);
        camThree.SetActive(false);
        camFour.SetActive(false);
        camFive.SetActive(false);
        camSix.SetActive(false);

        camLocation = true;
    }

    public bool IsCameraInside()
    {
        return camLocation;
    }

    public int ActiveCamNum()
    {
        return camNum;
    }

    // Update is called once per frame
    void Update()
    {
        //Keys: 1-6, Control cams
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camOne.SetActive(true);
            camTwo.SetActive(false);
            camThree.SetActive(false);
            camFour.SetActive(false);
            camFive.SetActive(false);
            camSix.SetActive(false);

            camLocation = true;
            camNum = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camOne.SetActive(false);
            camTwo.SetActive(true);
            camThree.SetActive(false);
            camFour.SetActive(false);
            camFive.SetActive(false);
            camSix.SetActive(false);

            camLocation = true;
            camNum = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camOne.SetActive(false);
            camTwo.SetActive(false);
            camThree.SetActive(true);
            camFour.SetActive(false);
            camFive.SetActive(false);
            camSix.SetActive(false);

            camLocation = true;
            camNum = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            camOne.SetActive(false);
            camTwo.SetActive(false);
            camThree.SetActive(false);
            camFour.SetActive(true);
            camFive.SetActive(false);
            camSix.SetActive(false);

            camLocation = true;
            camNum = 4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            camOne.SetActive(false);
            camTwo.SetActive(false);
            camThree.SetActive(false);
            camFour.SetActive(false);
            camFive.SetActive(true);
            camSix.SetActive(false);

            camLocation = false;
            camNum = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            camOne.SetActive(false);
            camTwo.SetActive(false);
            camThree.SetActive(false);
            camFour.SetActive(false);
            camFive.SetActive(false);
            camSix.SetActive(true);

            camLocation = false;
            camNum = 6;
        }
    }
}

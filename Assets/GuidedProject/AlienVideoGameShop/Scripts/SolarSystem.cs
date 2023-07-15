using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    //get the planet gameobject
    public GameObject sun;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    public GameObject P6;
    public GameObject P7;
    public GameObject P8;
    public GameObject P9;
    public GameObject P10;
    public GameObject P11;
    public GameObject P12;
    public GameObject P13;
    public GameObject P14;

    // Update is called once per frame
    void Update()
    {
        //rotate planet around the sun at X degrees
        P1.transform.RotateAround(sun.transform.position, Vector3.up, 20 * Time.deltaTime);
        P2.transform.RotateAround(sun.transform.position, Vector3.up, 18 * Time.deltaTime);
        P3.transform.RotateAround(sun.transform.position, Vector3.up, 4 * Time.deltaTime);
        P4.transform.RotateAround(sun.transform.position, Vector3.up, 10 * Time.deltaTime);
        P5.transform.RotateAround(sun.transform.position, Vector3.up, 20 * Time.deltaTime);
        P6.transform.RotateAround(sun.transform.position, Vector3.up, 23 * Time.deltaTime);
        P7.transform.RotateAround(sun.transform.position, Vector3.up, 16 * Time.deltaTime);
        P8.transform.RotateAround(sun.transform.position, Vector3.up, 10 * Time.deltaTime);
        P9.transform.RotateAround(sun.transform.position, Vector3.up, 7 * Time.deltaTime);
        P10.transform.RotateAround(sun.transform.position, Vector3.up, 7 * Time.deltaTime);
        P11.transform.RotateAround(sun.transform.position, Vector3.up, 12 * Time.deltaTime);
        P12.transform.RotateAround(sun.transform.position, Vector3.up, 18 * Time.deltaTime);
        P13.transform.RotateAround(sun.transform.position, Vector3.up, 14 * Time.deltaTime);
        P14.transform.RotateAround(sun.transform.position, Vector3.up, 4 * Time.deltaTime);
    }

}

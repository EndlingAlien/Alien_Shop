using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{

    public GameObject sun;
    public GameObject planetOne;
    public GameObject planetTwo;
    public GameObject planetThree;
    public GameObject planetFour;
    public GameObject planetFive;
    public GameObject planetSix;
    public GameObject planetSeven;

    // Update is called once per frame
    void Update()
    {
        planetOne.transform.RotateAround(sun.transform.position, Vector3.up, 25 * Time.deltaTime);
        planetTwo.transform.RotateAround(sun.transform.position, Vector3.up, 45 * Time.deltaTime);
        planetThree.transform.RotateAround(sun.transform.position, Vector3.up, 30 * Time.deltaTime);
        planetFour.transform.RotateAround(sun.transform.position, Vector3.up, 10 * Time.deltaTime);
        planetFive.transform.RotateAround(sun.transform.position, Vector3.up, 35 * Time.deltaTime);
        planetSix.transform.RotateAround(sun.transform.position, Vector3.up, 20 * Time.deltaTime);
        planetSeven.transform.RotateAround(sun.transform.position, Vector3.up, 5 * Time.deltaTime);
    }

}

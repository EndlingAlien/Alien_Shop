using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemMoons : MonoBehaviour
{
    //get planet for moon(s), and choose rotation speed
    public GameObject[] planets;
    public GameObject[] moons;
    public float[] rotationSpeeds;

    // Update is called once per frame
    void Update()
    {
        //each moon needs to rotate around chosen planet with rotation speed listed
        //ex: 5 moons on 1 planet, choose planet for each moon in array
        if (moons.Length != rotationSpeeds.Length || moons.Length != planets.Length)
        {
            Debug.LogError("The number of moons, rotation speeds, and planets must be the same.");
            return;
        }
        
        for (int i = 0; i < moons.Length; i++)
        {
            moons[i].transform.RotateAround(planets[i].transform.position, Vector3.up, rotationSpeeds[i] * Time.deltaTime);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemMoons : MonoBehaviour
{
    public GameObject[] planets;
    public GameObject[] moons;
    public float[] rotationSpeeds;

    // Update is called once per frame
    void Update()
    {
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
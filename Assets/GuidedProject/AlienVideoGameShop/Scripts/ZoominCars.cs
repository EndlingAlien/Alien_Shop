using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoominCars : MonoBehaviour
{
    //this script controlls the cars "pulling in"
    public GameObject[] carObjects;
    public float delayBeforeDelete = 2f; // Delay in seconds before deleting the car
    private GameObject currentCar;
    private Animator currentAnimator;

    private void Start()
    {
        SpawnRandomCar();
    }

    private void SpawnRandomCar()
    {
        // Randomly select a car from the array
        int randomIndex = Random.Range(0, carObjects.Length);
        GameObject carPrefab = carObjects[randomIndex];

        // Spawn the car at the position of this script's GameObject
        currentCar = Instantiate(carPrefab, transform.position, Quaternion.identity);
        currentCar.transform.parent = transform;
        currentAnimator = currentCar.GetComponent<Animator>();

        // Activate the default animation connected to the car
        currentAnimator.enabled = true;

        // Start the delay before deleting the car
        Invoke("DeleteCurrentCar", delayBeforeDelete);
    }

    private void DeleteCurrentCar()
    {
        if (currentCar != null)
        {
            Destroy(currentCar);
            SpawnRandomCar(); // Spawn the next random car
        }
    }
}






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

    //create list to add audio clips
    public List<AudioClip> spaceEngineList = new List<AudioClip>();
    private AudioSource currentSource;

    public CameraController cameraController;

    private void Start()
    {
        SpawnRandomCar();
    }

    private void Update()
    {
        // Get the active camera from the camera controller
        bool isInside = cameraController.IsCameraInside();


        //check which camera is active, and adjust audio
        if (isInside == true)
        {
            // Set volume low
            currentSource.volume = .3f;
        }
        else if (isInside == false)
        {
            currentSource.volume = 1f;
        }

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

        //get audio source from current prefab
        currentSource = currentCar.GetComponent<AudioSource>();

        // Activate the default animation connected to the car
        currentAnimator.enabled = true;

        //pick a random clip from list and play
        currentSource.clip = spaceEngineList[Random.Range(0, spaceEngineList.Count)];
        currentSource.Play();
        

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






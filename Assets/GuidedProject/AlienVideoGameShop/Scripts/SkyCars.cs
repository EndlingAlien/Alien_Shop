using System.Collections.Generic;
using UnityEngine;

public class SkyCars : MonoBehaviour
{
    //this script controlls the cars flying in the sky
    public GameObject[] carPrefabs;
    public float delayBeforeDelete = 2f; // Delay in seconds before deleting the car
    private GameObject currentCar;

    //create list to add audio clips
    public List<AudioClip> driveByList = new List<AudioClip>();
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
        if(isInside == true)
        {
            // Set volume low
            currentSource.volume = .15f;
        } else if (isInside == false)
        {
            currentSource.volume = 1f;
        }

    }

    private void SpawnRandomCar()
    {
        // Randomly select a car prefab from the array
        int randomIndex = Random.Range(0, carPrefabs.Length);
        GameObject carPrefab = carPrefabs[randomIndex];

        // Spawn the car at the position of this script's GameObject
        currentCar = Instantiate(carPrefab, transform.position, Quaternion.identity);
        currentCar.transform.parent = transform;

        //get audio source from current prefab
        currentSource = currentCar.GetComponent<AudioSource>();


        // Activate the animator for the car
        Animator carAnimator = currentCar.GetComponent<Animator>();
        carAnimator.enabled = true;

        //pick a random clip from list and play
        currentSource.clip = driveByList[Random.Range(0, driveByList.Count)];
        currentSource.PlayDelayed(.3f);

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







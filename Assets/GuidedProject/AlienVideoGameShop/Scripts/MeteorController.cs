using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public GameObject[] meteorPrefabs;
    public float delayBeforeDelete = 2f; // Delay in seconds before deleting the car
    private GameObject currentMeteor;

    private void Start()
    {
        SpawnRandomMeteor();
    }

    private void SpawnRandomMeteor()
    {
        // Randomly select a Meteor prefab from the array
        int randomIndex = Random.Range(0, meteorPrefabs.Length);
        GameObject meteorPrefab = meteorPrefabs[randomIndex];

        // Spawn the Meteor at the position of this script's GameObject
        currentMeteor = Instantiate(meteorPrefab, transform.position, Quaternion.identity);
        currentMeteor.transform.parent = transform;

        // Activate the animator for the Meteor
        Animator carAnimator = currentMeteor.GetComponent<Animator>();
        carAnimator.enabled = true;

        // Start the delay before deleting the Meteor
        Invoke("DeleteCurrentCar", delayBeforeDelete);
    }

    private void DeleteCurrentCar()
    {
        if (currentMeteor != null)
        {
            Destroy(currentMeteor);
            SpawnRandomMeteor(); // Spawn the next random Meteor
        }
    }
}

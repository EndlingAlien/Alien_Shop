using UnityEngine;

public class SkyCars : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public float delayBeforeDelete = 2f; // Delay in seconds before deleting the car
    private GameObject currentCar;

    private void Start()
    {
        SpawnRandomCar();
    }

    private void SpawnRandomCar()
    {
        // Randomly select a car prefab from the array
        int randomIndex = Random.Range(0, carPrefabs.Length);
        GameObject carPrefab = carPrefabs[randomIndex];

        // Spawn the car at the position of this script's GameObject
        currentCar = Instantiate(carPrefab, transform.position, Quaternion.identity);
        currentCar.transform.parent = transform;

        // Activate the animator for the car
        Animator carAnimator = currentCar.GetComponent<Animator>();
        carAnimator.enabled = true;

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







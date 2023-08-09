using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuCamTransition : MonoBehaviour
{
    public bool isBtnClicked = false;

    public GameObject particles;
    //camera variables
    public GameObject camera;
    public float moveSpeed = 5f;
    public float rotationSpeed = 45.0f;
    public Vector3 moveDirection = Vector3.forward;
    //scene variables
    public float waitDelay = 4f;
    public Animator sceneTransitionAnimator;
    public string nextSceneName;

    private bool isRotating = true;

    // Update is called once per frame
    void Update()
    {
        if (isBtnClicked == true)
        {
            AnimTransition();
        }
    }

    public void AnimTransition()
    {
        particles.SetActive(true);

        // Rotate the camera to y-rotation 0
        if (isRotating)
        {
            Quaternion targetRotation = Quaternion.Euler(0f, 0f, 0f);
            camera.transform.rotation = Quaternion.RotateTowards(camera.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Check if the rotation is close to the target
            if (Quaternion.Angle(camera.transform.rotation, targetRotation) < 0.1f)
            {
                isRotating = false;
            }
        }
        else
        {
            // Start scene transition animation
            sceneTransitionAnimator.SetTrigger("FadeOut");

            // Load the next scene after a delay
            StartCoroutine(LoadSceneWithDelay());

            camera.transform.Translate(moveDirection * moveSpeed);
        }
    }

    private IEnumerator LoadSceneWithDelay()
    {
        // Wait for a brief moment while the animations play
        yield return new WaitForSecondsRealtime(waitDelay);

        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }


    //just for onClick() button ui to set everything in motion
    public void ClickButton()
    {
        isBtnClicked = true;
    }
}


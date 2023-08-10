using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    #region All the Variables
    //get the things
    public GameObject spaceMusic;
    public GameObject storeMusic;

    private AudioSource storeSource;
    private AudioSource spaceSource;

    public GameObject pauseMenu;

    //all for dialogue on correct cam
    public GameObject storeCC;
    public GameObject spaceCC;
    public GameObject dialogueCC;

    public CameraController cameraController;
    private int cameraNum;

    //for checking if music/caption  is on
    private bool isSpaceMusicOn;
    private bool isStoreMusicOn;
    private bool isCaptionOn;

    //toggles
    public Toggle captionsToggle;
    public Toggle spaceMusicToggle;
    public Toggle storeMusicToggle;

    //sliders
    public Slider storeSlider;
    public Slider spaceSlider;

    public SettingsData settingsData;
    #endregion

    void Start()
    {
        storeSource = storeMusic.GetComponent<AudioSource>();
        spaceSource = spaceMusic.GetComponent<AudioSource>();

        //default values
        isCaptionOn = false;
        isSpaceMusicOn = false;
        isStoreMusicOn = true;

    }

    void Update()
    {
        //press p for pause menu
        if (Input.GetKeyDown(KeyCode.P))
        {
            ActivatePause();
        }

        //store music toggle controls the gameobject
        if(isStoreMusicOn == true)
        {
            storeMusic.SetActive(true);
        } else if(isStoreMusicOn == false)
        {
            storeMusic.SetActive(false);
        }

        //space music toggle controls the gameobject
        if (isSpaceMusicOn == true)
        {
            spaceMusic.SetActive(true);
        }
        else if (isSpaceMusicOn == false)
        {
            spaceMusic.SetActive(false);
        }

        #region Closed Captions and Cameras

        //checks what camera were on for correct captions
        cameraNum = cameraController.ActiveCamNum();

        //camera 1,3,4
        if (isCaptionOn && isStoreMusicOn && cameraNum == 1 || isCaptionOn && isStoreMusicOn && cameraNum == 3 || isCaptionOn && isStoreMusicOn && cameraNum == 4)
        {
            storeCC.SetActive(true);
            spaceCC.SetActive(false);
            dialogueCC.SetActive(false);
        } else if (isCaptionOn && !isStoreMusicOn && cameraNum == 1 || isCaptionOn && !isStoreMusicOn && cameraNum == 3 || isCaptionOn && !isStoreMusicOn && cameraNum == 4)
        {
            storeCC.SetActive(false);
            spaceCC.SetActive(false);
            dialogueCC.SetActive(false);
        }

        //camera 2
        if(isCaptionOn && isStoreMusicOn && cameraNum == 2)
        {
            storeCC.SetActive(true);
            spaceCC.SetActive(false);
            dialogueCC.SetActive(true);
        } else if (isCaptionOn && !isStoreMusicOn && cameraNum == 2)
        {
            storeCC.SetActive(false);
            spaceCC.SetActive(false);
            dialogueCC.SetActive(true);
        } else if (!isCaptionOn && !isStoreMusicOn && cameraNum == 2)
        {
            storeCC.SetActive(false);
            spaceCC.SetActive(false);
            dialogueCC.SetActive(false);
        }

        //camera 5
        if (isCaptionOn && cameraNum == 5)
        {
            storeCC.SetActive(false);
            spaceCC.SetActive(false);
            dialogueCC.SetActive(true);
        } else if (!isCaptionOn && cameraNum == 5)
        {
            storeCC.SetActive(false);
            spaceCC.SetActive(false);
            dialogueCC.SetActive(false);
        }

        //camera 6
        if (isCaptionOn && isSpaceMusicOn && cameraNum == 6)
        {
            storeCC.SetActive(false);
            spaceCC.SetActive(true);
            dialogueCC.SetActive(false);
        } else if (isCaptionOn && !isSpaceMusicOn && cameraNum == 6)
        {
            storeCC.SetActive(false);
            spaceCC.SetActive(false);
            dialogueCC.SetActive(false);
        }
        #endregion
    }

    public void ActivatePause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void DeactivatePause()
    {
        Time.timeScale = 1f;
    }

    #region The methods for the UI
    //just for sliders
    public void StoreMusicVolume()
    {
        settingsData.SetStoreMusicVolume(storeSlider.value);
        storeSource.volume = storeSlider.value;
        Debug.Log("Store volume is " + settingsData.storeMusicVolume);
    }

    public void SpaceMusicVolume()
    {
        settingsData.SetSpaceMusicVolume(spaceSlider.value);
        spaceSource.volume = spaceSlider.value;
        Debug.Log("Space volume is " + settingsData.spaceMusicVolume);
    }

    //just for respective toggles

    public void ToggleCaptions()
    {
        isCaptionOn = captionsToggle.isOn;
        Debug.Log("Captions are " + isCaptionOn);
    }

    public void ToggleSpaceMusic()
    {
        isSpaceMusicOn = spaceMusicToggle.isOn;
        Debug.Log("Space music is " + isSpaceMusicOn);
    }

    public void ToggleStoreMusic()
    {
        isStoreMusicOn = storeMusicToggle.isOn;
        Debug.Log("Store music is " + isStoreMusicOn);
    }

    //onclick() action for menu btn in pause menu
    public void BacktoMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    #endregion
}

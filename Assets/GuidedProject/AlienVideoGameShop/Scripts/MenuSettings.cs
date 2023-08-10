using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSettings : MonoBehaviour
{
    public GameObject menuMusic;
    private AudioSource menuSource;

    public Toggle musicToggle;
    public Slider menuMusicSlider;
    public bool isMenuMusicOn;

    public SettingsData settingsData;

    // Start is called before the first frame update
    void Start()
    {
        menuSource = menuMusic.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        //store music toggle controls the gameobject
        if (settingsData.isMenuMusicOn == true)
        {
            menuMusic.SetActive(true);
        }
        else if (settingsData.isMenuMusicOn == false)
        {
            menuMusic.SetActive(false);
        }
    }

    public void MenuMusicVolume()
    {
        settingsData.SetMenuMusicVolume(menuMusicSlider.value);
        menuSource.volume = menuMusicSlider.value;
        Debug.Log("Space volume is " + settingsData.menuMusicVolume);
    }

    public void ToggleMusic()
    {
        settingsData.isMenuMusicOn = musicToggle.isOn;
        Debug.Log("Captions are " + settingsData.isCaptionOn);
    }
}

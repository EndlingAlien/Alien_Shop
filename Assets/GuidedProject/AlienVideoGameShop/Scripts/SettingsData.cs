using UnityEngine;

[CreateAssetMenu(fileName = "SettingsData", menuName = "ScriptableObjects/SettingsData")]
public class SettingsData : ScriptableObject
{
    public bool isMenuMusicOn;
    public bool isSpaceMusicOn;
    public bool isStoreMusicOn;
    public bool isCaptionOn;

    public float menuMusicVolume;
    public float spaceMusicVolume;
    public float storeMusicVolume;


    public void SetStoreMusicVolume(float volume)
    {
        storeMusicVolume = volume;
        // Apply the volume change to your audio source
    }

    public void SetSpaceMusicVolume(float volume)
    {
        spaceMusicVolume = volume;
        // Apply the volume change to your audio source
    }

    public void SetMenuMusicVolume(float volume)
    {
        menuMusicVolume = volume;
        // Apply the volume change to your audio source
    }
}

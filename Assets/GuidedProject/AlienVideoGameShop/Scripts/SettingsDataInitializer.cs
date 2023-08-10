using UnityEngine;

public class SettingsDataInitializer : MonoBehaviour
{
    public SettingsData initialSettingsData; // Reference to your initial SettingsData asset

    private void Start()
    {
        SettingsDataManager.Instance.settingsData = Instantiate(initialSettingsData);
    }
}


using UnityEngine;

public class SettingsDataManager : MonoBehaviour
{
    private static SettingsDataManager _instance;
    public SettingsData settingsData;

    public static SettingsDataManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

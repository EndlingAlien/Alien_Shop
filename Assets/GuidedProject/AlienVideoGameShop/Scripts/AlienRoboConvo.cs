using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienRoboConvo : MonoBehaviour
{

    public GameObject robotAudio;
    public GameObject alienAudio;
    private AudioSource robotSource;
    private AudioSource alienSource;
    public AudioClip[] alienClips;
    public AudioClip[] robotClips;

    // Start is called before the first frame update
    void Start()
    {
        robotSource = robotAudio.GetComponent<AudioSource>();
        alienSource = alienAudio.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!robotSource.isPlaying)
        {
            PlayRandomRobotClip();
        }

        if (!alienSource.isPlaying)
        {
            PlayRandomAlienClip();
        }
    }

    private void PlayRandomRobotClip()
    {
        int randomRange = Random.Range(0,7);
        AudioClip randomClip = robotClips[randomRange];
        robotSource.clip = randomClip;
        robotSource.Play();
    }

    private void PlayRandomAlienClip()
    {
        int randomRange = Random.Range(0,6);
        AudioClip randomClip = alienClips[randomRange];
        alienSource.clip = randomClip;
        alienSource.Play();
    }
}

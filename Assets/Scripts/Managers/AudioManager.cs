using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource doorAudioSource;

    //private List<AudioSource> gunAudioSources = new List<AudioSource>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GunShoot(AudioSource audioSource)
    {
        audioSource.Play();
    }

    public void DoorSqueak(AudioSource audioSource)
    {
        audioSource.Play();
    }

}

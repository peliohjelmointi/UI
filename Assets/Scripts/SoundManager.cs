using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;

    public AudioMixer mixer;
    AudioSource audioSource;

    public Slider volumeSlider; //slider löytyy, kun using UnityEngine.UI

    public void Awake()
    {   //"Singleton"
        if(soundManager == null)
        {
            DontDestroyOnLoad(gameObject);
            soundManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = volumeSlider.value;
    }

    public void SetVolume()
    {
        mixer.SetFloat("MasterVolume", Mathf.Log10(volumeSlider.value) * 20);
        //print(Mathf.Log10(volumeSlider.value) * 20);
    }

}

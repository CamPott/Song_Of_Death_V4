using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laptop_Screen : MonoBehaviour
{
    public GameObject _PlayScreen;

    public AudioClip _VoiceClip;
    public AudioSource audioSource;

    public bool alreadyPlayed = false;

    private void Start()
    {
        _PlayScreen.SetActive(false);

        AudioSource _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player_Hands" && !alreadyPlayed)
        {
            _PlayScreen.SetActive(true);

            audioSource.PlayOneShot(_VoiceClip, 0.7f);
            alreadyPlayed = true;

            Debug.Log("Screen Appears & Audio Plays");
        }
    }
}

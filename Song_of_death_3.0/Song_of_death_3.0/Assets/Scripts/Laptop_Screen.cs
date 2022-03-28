using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laptop_Screen : MonoBehaviour
{
    public GameObject _PlayScreen;

    public AudioClip _VoiceClip;
    AudioSource audioSource;

    private void Start()
    {
        _PlayScreen.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player_Hands")
        {
            _PlayScreen.SetActive(true);
            audioSource.PlayOneShot(_VoiceClip, 0.7f);
            Debug.Log("Screen Appears & Audio Plays");
        }
    }
}

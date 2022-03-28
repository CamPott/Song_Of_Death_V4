using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TV_Screen : MonoBehaviour
{
    public GameObject _PlayScreen;

    public AudioClip _BreakingNewsSFX;
    public AudioSource _audio;

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

            _audio.PlayOneShot(_BreakingNewsSFX, 0.7f);
            alreadyPlayed = true;
            Debug.Log("Screen Appears & Audio Plays");
        }
    }
}

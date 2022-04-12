using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class song : MonoBehaviour
{
    public AudioSource _audio;
    public bool alreadyPlayed = false;

    private void Start()
    {
        AudioSource _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player_Hands" && !alreadyPlayed)
        {
            _audio.Play();
            alreadyPlayed = true;

            Debug.Log("Audio Plays");
        }

        if (other.tag == "Player_Hands" && alreadyPlayed)
        {
            _audio.Stop();
            alreadyPlayed = false;

            Debug.Log("Audio Stops");
        }
    }
}

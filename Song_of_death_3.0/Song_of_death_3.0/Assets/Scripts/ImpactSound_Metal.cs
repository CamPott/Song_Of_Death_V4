using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound_Metal : MonoBehaviour
{
    public AudioSource _ImpactSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 3)
        {
            _ImpactSound.Play();
        }
    }
}

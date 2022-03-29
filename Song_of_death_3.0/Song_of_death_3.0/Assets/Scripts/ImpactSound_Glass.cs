using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound_Glass : MonoBehaviour
{
    public AudioSource _ImpactSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude < 5)
        {
            _ImpactSound.Play();

        } else if (collision.relativeVelocity.magnitude > 5)
        {
            _ImpactSound.Play();
            Destroy(gameObject);
            
        }
    }
}

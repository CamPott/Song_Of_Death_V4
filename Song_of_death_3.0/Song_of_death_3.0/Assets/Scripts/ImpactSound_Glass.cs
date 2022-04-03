using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound_Glass : MonoBehaviour
{
    public AudioSource _ImpactSound;

    public MeshRenderer _GlassObject;

    private void Start()
    {
        _GlassObject = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude >= 5)
        {
            _ImpactSound.Play();
            GetComponent<MeshRenderer>().enabled = false;

        } //else if (collision.relativeVelocity.magnitude >= 3)
        //{
           // _ImpactSound.Play();
            
            
        //}
    }
}

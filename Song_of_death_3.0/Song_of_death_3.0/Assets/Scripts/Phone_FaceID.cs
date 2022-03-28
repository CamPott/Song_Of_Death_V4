using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phone_FaceID : MonoBehaviour
{
    public GameObject _TextScreen;

    private void Start()
    {
        _TextScreen.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Body_Head")
        {
            _TextScreen.SetActive(true);
            Debug.Log("Screen Appears");
        }
    }
}

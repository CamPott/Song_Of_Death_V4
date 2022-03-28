using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Phone_ButtonPushed : MonoBehaviour
{
    public static event Action<string> ButtonPressed = delegate { };

    private int _DividerPos;
    private string _ButtonName, _ButtonValue;

    // Start is called before the first frame update
    void Start()
    {
        _ButtonName = gameObject.name;
        _DividerPos = _ButtonName.IndexOf("_");
        _ButtonValue = _ButtonName.Substring(0, _DividerPos);

        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {
        ButtonPressed(_ButtonValue);
    }
}

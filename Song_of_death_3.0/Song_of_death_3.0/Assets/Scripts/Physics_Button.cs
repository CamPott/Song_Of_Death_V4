using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Physics_Button : MonoBehaviour
{
    [SerializeField]
    private float threshold = .1f;

    [SerializeField]
    private float deadZone = 0.025f;

    private bool _isPressed;
    private Vector3 _startPos;
    private ConfigurableJoint _Joint;

    public UnityEvent OnPressed, OnReleased;

    Animator anim;

    

    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.localPosition;
        _Joint = GetComponent<ConfigurableJoint>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
            Pressed();
        
        if (_isPressed && GetValue() - threshold <= 0)
            Released();
    }

    private float GetValue ()
    {
        var value = Vector3.Distance(_startPos, transform.localPosition) / _Joint.linearLimit.limit;

        if (Mathf.Abs(value) < deadZone)
            value = 0;

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        _isPressed = true;
        OnPressed.Invoke();
        Debug.Log("Pressed");
        
        
    }

   
    private void Released()
    {
        _isPressed = false;
        OnReleased.Invoke();
        Debug.Log("Released");
    }
}

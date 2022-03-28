using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class Hand_Controller : MonoBehaviour
{
    ActionBasedController _Controller;

    public Hand _hand;

    // Start is called before the first frame update
    void Start()
    {
        _Controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        _hand.SetGrip(_Controller.selectAction.action.ReadValue<float>());
        _hand.SetTrigger(_Controller.activateAction.action.ReadValue<float>());
    }
}

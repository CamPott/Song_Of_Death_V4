using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    Animator animator;

    SkinnedMeshRenderer _Mesh;

    private float _GripTarget;
    private float _TriggerTarget;
    private float _GripCurrent;
    private float _TriggerCurrent;

    public float speed;

    private string _AnimatorGripParam = "Grip";
    private string _AnimatorTriggerParam = "Trigger";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _Mesh = GetComponentInChildren<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip (float v)
    {
        _GripTarget = v;
    }

    internal void SetTrigger ( float v)
    {
        _TriggerTarget = v;
    }

    void AnimateHand()
    {
        if (_GripCurrent != _GripTarget)
        {
            _GripCurrent = Mathf.MoveTowards(_GripCurrent, _GripTarget, Time.deltaTime * speed);
            animator.SetFloat(_AnimatorGripParam, _GripCurrent);
        }
        if (_TriggerCurrent != _TriggerTarget)
        {
            _TriggerCurrent = Mathf.MoveTowards(_TriggerCurrent, _TriggerTarget, Time.deltaTime * speed);
            animator.SetFloat(_AnimatorTriggerParam, _TriggerCurrent);
        }
    }

    public void ToggleVisibility()
    {
        _Mesh.enabled = !_Mesh.enabled;
    }
}

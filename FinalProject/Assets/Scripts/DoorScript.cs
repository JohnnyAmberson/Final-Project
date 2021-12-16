using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    HingeJoint _hinge; // creates a class so we can use the hingejoint
    [SerializeField]
    AudioSource _creak; // class GameObject with a serialized field so we can set the object we want to disappear
    private void Start()
    {
        _hinge = GetComponent<HingeJoint>();// applies the door's hingejoint component to the hingejoint class
    }
    private void Update()
    {
        if (_hinge.angle != _hinge.limits.min)
        {
            _creak.Play();
        }
    }
}

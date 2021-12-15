using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript2 : MonoBehaviour
{
    bool _flint;
    bool _steel;
    [SerializeField]
    GameObject _fire;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("flint"))
        {
            _flint = true;
        }
        if (other.gameObject.CompareTag("steel"))
        {
            _steel = true;
        }
        if (_steel && _flint)
        {
            _fire.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("flint"))
        {
            _flint = false;
        }
        if (other.gameObject.CompareTag("steel"))
        {
            _steel = false;
        }
    }
}

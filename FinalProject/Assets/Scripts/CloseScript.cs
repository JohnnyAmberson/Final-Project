using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseScript : MonoBehaviour
{
    public bool _isClose = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("flint&Steel"))
        {
            _isClose = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("flint&Steel"))
        {
            _isClose = false;
        }
    }
}

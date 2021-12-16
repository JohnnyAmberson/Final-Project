using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    Rigidbody rb2;
    AudioSource _click;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("key"))
        {
            rb.constraints = rb2.constraints;
        }
        _click.Play();
    }
}

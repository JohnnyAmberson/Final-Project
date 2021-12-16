using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapeScript : MonoBehaviour
{
    [SerializeField]
    AudioSource _scrape;
    private void Update()
    {
        if (gameObject.GetComponent<Rigidbody>().velocity.magnitude > 0.1)
        {
            _scrape.Play();
        }
    }
}

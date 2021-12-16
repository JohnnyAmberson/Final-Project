using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerScript : MonoBehaviour
{
    [SerializeField]
    AudioMixerSnapshot _inside;
    [SerializeField]
    AudioMixerSnapshot _outside;
    [SerializeField]
    float _transitionTime;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            _inside.TransitionTo(_transitionTime);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            _outside.TransitionTo(_transitionTime);
        }
    }
}

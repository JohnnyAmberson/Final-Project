using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{
    
    [SerializeField]
    AudioSource _ambience;
    Slider _slider;
    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();
    }
    public void VolumeChange()
    {
        _ambience.volume = _slider.value;
    }
}

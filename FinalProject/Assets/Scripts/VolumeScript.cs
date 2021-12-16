using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{
    
    [SerializeField]
    AudioSource _ambience;
    [SerializeField]
    AudioSource _fire;
    [SerializeField]
    AudioSource _click;
    [SerializeField]
    AudioSource _creak;
    [SerializeField]
    AudioSource _artifact;
    [SerializeField]
    AudioSource _whistle;
    Slider _slider;
    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();
    }
    public void VolumeChange()
    {
        _ambience.volume = _slider.value;
        _artifact.volume = _slider.value;
        _click.volume = _slider.value;
        _creak.volume = _slider.value;
        _fire.volume = _slider.value;
        _whistle.volume = _slider.value;
    }
}

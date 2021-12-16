using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float _timer = 60;
    PauseScript ps;
    [SerializeField]
    GameObject _gameObject;
    private void Start()
    {
        _timer = 60;
    }
    // Update is called once per frame
    void Update()
    {
        if (_gameObject.activeInHierarchy)
        {
            _timer -= Time.deltaTime;
        }
        

    }

}

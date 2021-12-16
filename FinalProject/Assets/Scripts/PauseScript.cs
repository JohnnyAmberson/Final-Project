using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System;


public class PauseScript : MonoBehaviour
{
    TimerScript ts;
    [SerializeField]
    TextMeshProUGUI _time;
    //bool _unPaused;
    [SerializeField]
    InputActionReference _pause; //Serialized field for the action used to pause the game
    [SerializeField]
    GameObject _left;
    [SerializeField]
    GameObject _right;
    [SerializeField]
    GameObject _pauseMenu;
    [SerializeField]
    GameObject _gameObject;
    public float _timer = 60;
    PauseScript ps;
    private void Start()
    {
        _timer = 60;
        _pause.action.started += Pause; //Now when the action is performed a custom method is called
    }
    // Update is called once per frame
    void Update()
    {
        if (_gameObject.activeInHierarchy)
        {
            _timer -= Time.deltaTime;
        }
        _time.text = _timer.ToString();

    }
   
    
    public void Pause(InputAction.CallbackContext obj)
    {
        _left.SetActive(true);
        _right.SetActive(true);
        _pauseMenu.SetActive(true);
        _gameObject.SetActive(false);
    }
    public void Unpause()
    {
        _left.SetActive(false);
        _right.SetActive(false);
        _gameObject.SetActive(true);
    }
}


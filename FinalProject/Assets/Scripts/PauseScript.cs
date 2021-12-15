using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PauseScript : MonoBehaviour
{
    public bool _isPaused;
    [SerializeField]
    InputActionReference _pause; //Serialized field for the action used to pause the game
    [SerializeField]
    GameObject _left;
    [SerializeField]
    GameObject _right;
    [SerializeField]
    GameObject _pauseMenu;
    private void Start() //Called before first frame
    {
        _pause.action.started += Pause; //Now when the action is performed a custom method is called
    }
    public void Pause(InputAction.CallbackContext obj)
    {
        _left.SetActive(true);
        _right.SetActive(true);
        _pauseMenu.SetActive(true);
        _isPaused = true;
    }
    public void Unpause()
    {
        _left.SetActive(false);
        _right.SetActive(false);
        _pauseMenu.SetActive(false);
        _isPaused = false;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    [SerializeField]
    GameObject _winScreeen;
    [SerializeField]
    GameObject _gameObject;
    [SerializeField]
    GameObject _left;
    [SerializeField]
    GameObject _right;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("lid"))
        {
            _winScreeen.SetActive(true);
            _gameObject.SetActive(false);
            _left.SetActive(true);
            _right.SetActive(true);
        }
    }
}

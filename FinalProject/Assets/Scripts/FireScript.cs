using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    CloseScript cs;
    [SerializeField]
    GameObject _fire;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("flint&Steel") && cs._isClose)
        {
            _fire.SetActive(true);
        }
    }
}

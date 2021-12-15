using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    CloseScript cs;
    [SerializeField]
    GameObject _Fire;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("flint&Steel") && cs._isClose)
        {
            _Fire.SetActive(true);
        }
    }
}

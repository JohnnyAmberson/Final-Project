using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    [SerializeField]
    GameObject _startPoint;
    public void Restart()
    {

        gameObject.transform.position = _startPoint.transform.position;
        gameObject.transform.rotation = _startPoint.transform.rotation;
    }
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}

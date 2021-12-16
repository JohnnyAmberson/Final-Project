using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    [SerializeField]
    GameObject _startPoint;
    Transform[] _transforms;
    private void Start()
    {
        
    }
    public void Restart()
    {

        gameObject.transform.SetPositionAndRotation(_startPoint.transform.position, _startPoint.transform.rotation);

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

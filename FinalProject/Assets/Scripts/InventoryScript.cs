using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    [SerializeField]
    GameObject _item1;
    [SerializeField]
    GameObject _item2;
    [SerializeField]
    GameObject _spawn;
    [SerializeField]
    GameObject _spawn2;
    bool _inStock;
    private void Start()
    {
        _inStock = true;
    }
    public void TakeOut()
    {
        if (_inStock)
        {
            Instantiate(_item1, _spawn.transform.position, Quaternion.identity);
            Instantiate(_item2, _spawn2.transform.position, Quaternion.identity);
            _inStock = false;
        }
        
    }


}

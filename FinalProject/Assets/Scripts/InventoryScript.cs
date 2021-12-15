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
    List<GameObject> inventory;
    private void Awake()
    {
        inventory.Add(_item1);
        inventory.Add(_item2);
    }
    public void TakeOut()
    {
        Instantiate(inventory[0], _spawn.transform.position, Quaternion.identity);
        Instantiate(inventory[1], _spawn2.transform.position, Quaternion.identity);
        inventory.Remove(_item1);
        inventory.Remove(_item2);
    }


}

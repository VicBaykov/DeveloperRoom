using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> item = new List<Item>();

    public void RemoveItem(Item item)
    {
        GameObject obj = Instantiate<GameObject>(Resources.Load<GameObject>(item.pathPrefab), transform.position + transform.forward + transform.up, Quaternion.identity);
        this.item.Remove(item);
    }

    public void UseItem(Item item)
    {
        
    }
}

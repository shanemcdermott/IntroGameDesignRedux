using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    public Dictionary<string, ItemData> items = new Dictionary<string, ItemData>();

    public bool AddItem(ItemData item)
    {
        ItemData data;
        if(items.TryGetValue(item.name, out data))
        {
            data.quantity += item.quantity;    
        }
        else
        {
            data = item;
        }

        items.Add(item.name, data);

        return true;
    }

}

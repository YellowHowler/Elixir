using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<Items> itemList;

    public InventoryManager()
    {
        itemList = new List<Items>();

        AddItem(new Items{itemType = Items.ItemType.PotionThin, amount = 1});
        
    }

    public void AddItem(Items item)
    {
        itemList.Add(item);
    }

    public List<Items> GetItemList()
    {
        return itemList;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

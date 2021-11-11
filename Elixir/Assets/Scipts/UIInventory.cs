using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    private InventoryManager inventory;
    [SerializeField] private Transform itemSlotContainer;
    [SerializeField] private Transform itemSlotTemplate;
    private RectTransform cellRectTransform;

    [SerializeField] private int slotNum;
    private int widthNum = 4;
    private float space;
    private float cellSize;

    public void SetInventory(InventoryManager inventory)
    {
        cellRectTransform = itemSlotContainer.gameObject.GetComponent<RectTransform>();
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    // Start is called before the first frame update
    void Awake()
    {
        cellSize = 70f;
        space = (float)(cellRectTransform.rect.width - cellSize * widthNum) / (float)(widthNum + 1);
    }

    // Update is called once per frame

    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;

        Vector3 containerPos = itemSlotContainer.position;

        for(int i = 0; i < slotNum; i++)
        {
            RectTransform itemSlot = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlot.anchoredPosition += new Vector2(x * cellSize, y * cellSize);
            itemSlot.gameObject.SetActive(true);

            Debug.Log("x: " + x);

            x++;

            if(x == widthNum)
            {
                x = 0;
                y++;
            }
        }
    }
    void Update()
    {
        
    }
}

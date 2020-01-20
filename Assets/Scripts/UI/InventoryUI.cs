using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public List<DragUI> drags = new List<DragUI>();

    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowUI()
    {
        if (!transform.gameObject.activeSelf) 
        {
            UpdateDrag();
        }
        transform.gameObject.SetActive(!transform.gameObject.activeSelf);
    }

    public void AddSubscriber(DragUI dragUI)
    {
        dragUI.PointerClickUse_Action += OnDragClickUse;
        dragUI.PointerClickRemove_Action += OnDragClickRemove;

    }

    public void RemoveSubscriber(DragUI dragUI)
    {
        dragUI.PointerClickUse_Action -= OnDragClickUse;
        dragUI.PointerClickRemove_Action -= OnDragClickRemove;
    }

    public void OnDragClickUse(DragUI drag)
    {
        print("Use");
    }
    
    public void OnDragClickRemove(DragUI drag)
    {
        inventory.RemoveItem(drag.item);
        UpdateDrag();
    }

    public void UpdateDrag()
    {
        foreach (DragUI drag in drags)
        {
            drag.ClearCell();
        }
        for (int i = 0; i < inventory.item.Count; i++)
        {
            for (int j = 0; j < drags.Count; j++)
            {
                if (drags[j].ownerItem != "")
                {
                    if (inventory.item[i].isStackable)
                    {
                        if (drags[j].item.nameItem == inventory.item[i].nameItem)
                        {
                            drags[j].countItem++;
                            drags[j].count.text = drags[j].countItem.ToString();
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    drags[j].item = inventory.item[i];
                    drags[j].img.sprite = Resources.Load<Sprite>(inventory.item[i].pathSprite);
                    drags[j].ownerItem = "mine";
                    drags[j].countItem++;
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragUI : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public InventoryUI inventoryUI;
    
    public Item item;

    public string ownerItem;

    public int countItem;

    public Image img;

    public Sprite defaultSprite;

    public Text count;

    public Text descriptionCell;

    public Action PointerEnter_Action;

    public Action<DragUI> PointerClickRemove_Action;
    
    public Action<DragUI> PointerClickUse_Action;


    public Action PointerExit_Action;

    private void OnEnable()
    {
        inventoryUI.AddSubscriber(this);
    }

    private void OnDisable()
    {
       inventoryUI.RemoveSubscriber(this);
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (img.sprite)
        {
            if (eventData.button == PointerEventData.InputButton.Right)
            {
                PointerClickRemove_Action?.Invoke(this);
            }
            else if (eventData.button == PointerEventData.InputButton.Left)
            {
                PointerClickUse_Action?.Invoke(this);

            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

    public void ClearCell()
    {
        item = null;
        img.sprite = null;
        countItem = 0;
        count.text = "";
        ownerItem = "";
    }
}

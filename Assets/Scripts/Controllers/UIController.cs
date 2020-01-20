using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : Singleton<UIController>
{
    public Action UIShowInventory_Action;
    [SerializeField]
    private InventoryUI _inventoryUI;

    public Action<bool> AddOrRemoveFromInventory_Action;
    
    private void OnEnable()
    {
        InputController.Instance.PressedKeyI_Action += OnInventoryKeyPressed;
        UIShowInventory_Action += _inventoryUI.ShowUI;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnInventoryKeyPressed()
    {
         UIShowInventory_Action?.Invoke();
    }
}

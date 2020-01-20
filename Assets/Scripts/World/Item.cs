using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{
    public string nameItem;

    public string typeItem;

    public int priceItem;

    public float weightItem;

    public string pathSprite;

    public string pathPrefab;

    public bool isStackable;

    private void OnEnable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTakeInteraction()
    {
        
    }

    public void OnRepairInteraction()
    {
        
    }

    public void OnHealInteraction()
    {
        
    }

    public void OnResearchInteraction()
    {
        
    }
}

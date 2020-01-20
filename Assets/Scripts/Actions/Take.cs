using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Take : Interaction
{
    public GameObject target;

    private Animator _animator;

    private InteractableObject _interactableObject;

    private Inventory _inventory;
   

    // Start is called before the first frame update
    void Start()
    {
        _inventory = GetComponent<Inventory>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DoInteraction();
    }

    public override bool CanInteract()
    {
        return (Vector3.Distance(transform.position + transform.up, target.transform.position) < 1.5f);
    }

    public override void DoInteraction()
    {
        if (!target)
            return;
        if (CanInteract())
        {
            //_animator.SetBool("Take", true);
            PutItemToInventory();
            _interactableObject.OnTakeInteraction();
        }
        else
        {
            Debug.Log("Too far from object");
            //_animator.SetBool("Take", false);
        }

        target = null;
        _interactableObject = null;
    }

    void PutItemToInventory()
    {
        _inventory.item.Add(target.GetComponent<Item>());
    }

    public void OnTakeItem(GameObject go)
    {
        Debug.Log("OnTakeItem");
        if ((target = go))
        {
            _interactableObject = target.GetComponent<InteractableObject>();
        }
    }
}
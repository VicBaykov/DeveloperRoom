using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public void OnTakeInteraction()
    {
        Destroy(transform.gameObject);
    }

    //public void OnRepairInteraction();
    //public void OnHealInteraction();
    //public void OnResearchInteraction();
}

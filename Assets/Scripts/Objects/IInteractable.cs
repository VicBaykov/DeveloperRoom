using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void OnTakeInteraction();
    void OnRepairInteraction();
    void OnHealInteraction();
    void OnResearchInteraction();
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interaction : MonoBehaviour
{   
    public abstract bool CanInteract();

    public abstract void DoInteraction();

    public bool Succeeded()
    {
        return (true);
    }

    public enum InteractionType
    {
        MOVE,
        TAKE,
        STEAL,
        REPAIR,
        HEAL
    }
}

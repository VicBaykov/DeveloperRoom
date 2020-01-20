using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{
    private List<EventListener> _eventListeners = new List<EventListener>();

    public void Register(EventListener listener)
    {
        _eventListeners.Add(listener);
    }

    public void Unregister(EventListener listener)
    {
        _eventListeners.Remove(listener);
    }

    public void Occured(GameObject go)
    {
        for (int i = 0; i < _eventListeners.Count; i++)
        {
            _eventListeners[i].OnEventOccurs(go);
        }
    }
}

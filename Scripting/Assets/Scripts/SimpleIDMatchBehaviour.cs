using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatchBehaviour : MonoBehaviour
{

    public Id id;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIDBehavior>();

        if (otherID == id)
        {
            matchEvent.Invoke();
            Debug.Log("Matched ID: " + id);
        }
        else
        {
            noMatchEvent.Invoke();
            Debug.Log("No Match: " + id);
        }
    }
}

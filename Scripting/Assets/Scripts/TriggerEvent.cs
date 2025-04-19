using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameObject particlePrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject particles = Instantiate(particlePrefab, other.transform.position, Quaternion.identity);
            Destroy(particles, 2f);  // Destroy after 2 seconds so it doesn't linger in the scene
        }
    }
}

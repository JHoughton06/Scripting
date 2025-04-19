using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerParticleSpawner : MonoBehaviour
{
    public GameObject particlePrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            GameObject spawnedParticles = Instantiate(particlePrefab, other.transform.position, Quaternion.identity);
            Destroy(spawnedParticles, 2f);  // Adjust lifetime to match your particle duration!
        }
    }
}


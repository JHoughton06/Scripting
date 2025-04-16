using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ RequireComponent(typeof(ParticleSystem), typeof(Collider))]

public class TriggerParticleEffect : MonoBehaviour
{
    public ParticleSystem particleEffect;
    public int firstEmissionAmount = 10;
    public int secondEmissionAmount = 8;
    public int thirdEmissionAmount = 3;
    public float delayBetweenEmissions = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }

    private IEnumerator EmitParticlesCoroutine()
    {
        if (particleEffect != null)
        {
            particleEffect.Emit(firstEmissionAmount);
            yield return new WaitForSeconds(delayBetweenEmissions);
            particleEffect.Emit(secondEmissionAmount);
            yield return new WaitForSeconds(delayBetweenEmissions);
            particleEffect.Emit(thirdEmissionAmount);
        }
    }
}

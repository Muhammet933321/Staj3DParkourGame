using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaliingRockSc : MonoBehaviour
{
    [SerializeField] GameObject ParticleEffect;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Instantiate(ParticleEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}

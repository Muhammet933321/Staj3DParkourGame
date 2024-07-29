using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaliingRockSc : MonoBehaviour
{
    [SerializeField] GameObject RockParticle;
    [SerializeField] GameObject BloodLake;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Instantiate(RockParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
        else if (collision.gameObject.tag == "Player")
        {
            Instantiate(BloodLake, collision.contacts[0].point, Quaternion.identity, collision.gameObject.transform);
        }
    }
}

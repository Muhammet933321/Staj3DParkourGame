using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaliingRockSc : MonoBehaviour
{
    [SerializeField] GameObject RockParticle;
    [SerializeField] GameObject BloodLake;
    GameObject PlayerObj;
    private void Start()
    {
        PlayerObj = GameObject.FindGameObjectWithTag("PlayerAnimator");
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag != "Player")
        {
            Instantiate(RockParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
        else if (collision.gameObject.tag == "Player")
        {
            PlayerObj.GetComponent<Animator>().SetBool("Death",true);
            Instantiate(BloodLake, collision.contacts[0].point, Quaternion.identity, collision.gameObject.transform);
        }
    }
}

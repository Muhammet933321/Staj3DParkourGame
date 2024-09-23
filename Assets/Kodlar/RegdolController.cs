using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegdolController : MonoBehaviour
{
    [SerializeField] Collider[] collisions;
    [SerializeField] Rigidbody[] rigidBodys;
    Animator animator;
    SUPERCharacterAIO controller;
     void Start()
    {
        collisions = GetComponentsInChildren<Collider>();
        rigidBodys = GetComponentsInChildren<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<SUPERCharacterAIO>();
        foreach (var collision in collisions)
        {
            collision.enabled = false;
        }
        foreach (Rigidbody rb in rigidBodys)
        {
            rb.isKinematic = true;
        }

        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Collider>().enabled = true;
        animator.enabled = true;
        controller.enabled = true;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            EnterRegdollFontion();
        }
        if (transform.position.y < -10)
        {
            EnterRegdollFontion();
        }
    }
    void EnterRegdollFontion()
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().isKinematic = true;
        foreach (var collision in collisions)
        {
            collision.enabled = true;
        }
        foreach (Rigidbody rb in rigidBodys)
        {
            rb.isKinematic = false;
        }
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().enabled = false;
        animator.enabled = false;
        
        controller.enabled = false;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnterRegdoll")
        {
            EnterRegdollFontion();
        }
    }
}

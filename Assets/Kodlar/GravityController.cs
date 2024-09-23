using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LowGravityArea")
        {
            Vector3 newGravity;
            newGravity.x = 0f;
            newGravity.y = -2f;
            newGravity.z = 0f;
            Physics.gravity = newGravity;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "LowGravityArea")
        {
            Vector3 newGravity;
            newGravity.x = 0f;
            newGravity.y = -9.81f;
            newGravity.z = 0f;
            Physics.gravity = newGravity;
        }
    }
}

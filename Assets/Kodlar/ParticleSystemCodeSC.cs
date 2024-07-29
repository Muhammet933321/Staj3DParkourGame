using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParticleSystemCodeSC : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyIt",1f);
    }

    private void DestroyIt()
    {
        Destroy(gameObject);
    }
}

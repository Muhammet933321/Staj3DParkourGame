using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] float Speed = 100;
    void Update()
    {
        transform.Rotate(0, Speed * Time.deltaTime, 0);
    }
}

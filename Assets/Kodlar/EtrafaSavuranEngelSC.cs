using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtrafaSavuranEngelSC : MonoBehaviour
{
    [SerializeField] float SavurmaGucu = 20f;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Carpisti !");
        Vector3 engelPozisyonu = transform.position;
        Vector3 KarakterPozisyonu = collision.transform.position;
        Vector3 SavurmaYonu = (KarakterPozisyonu  - engelPozisyonu).normalized ;
        collision.gameObject.GetComponent<Rigidbody>().velocity = SavurmaYonu * SavurmaGucu;
        Debug.Log("Savurma yonu = " + SavurmaYonu);
        Debug.Log("Savurma Gucu = " + SavurmaGucu);

    }
}

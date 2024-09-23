using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject LevelBitisMenusu;
    void Start()
    {
        LevelBitisMenusu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Oyun Bitti !!");
            LevelBitisMenusu.SetActive(true);

        }
    }
}

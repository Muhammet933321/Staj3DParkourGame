using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFaller : MonoBehaviour
{
    float SonDuselTasZamani;
    float TetiklenmeZamani;
    [SerializeField] GameObject Rock;
    GameObject Player;
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        TetiklenmeZamani = 1;
        SonDuselTasZamani = 0f;
    }
    void Update()
    {
        Vector3 RockSpawnPosition;
        if ( Time.time >= TetiklenmeZamani + SonDuselTasZamani )
        {
            SonDuselTasZamani = Time.time;
            RockSpawnPosition = Player.transform.position;
            RockSpawnPosition.y += 5f;
            
            Instantiate(Rock , RockSpawnPosition, Quaternion.identity);
           
        }
    }
}

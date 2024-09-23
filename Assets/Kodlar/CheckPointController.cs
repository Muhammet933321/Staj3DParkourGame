using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointController : MonoBehaviour
{
    Vector3 checkPointPosition;
    void Start()
    {
        if (PlayerPrefs.HasKey("CheckPointX"))
        {
            checkPointPosition.x = PlayerPrefs.GetFloat("CheckPointX");
            checkPointPosition.y = PlayerPrefs.GetFloat("CheckPointY");
            checkPointPosition.z = PlayerPrefs.GetFloat("CheckPointZ");
        }
        else
        {
            checkPointPosition = transform.position;
        }

        transform.position = checkPointPosition;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            PlayerPrefs.DeleteKey("CheckPointX");
            PlayerPrefs.DeleteKey("CheckPointY");
            PlayerPrefs.DeleteKey("CheckPointZ");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CheckPointArea")
        {
            if (checkPointPosition.y < other.transform.position.y)
            {
                checkPointPosition = other.transform.position;

                PlayerPrefs.SetFloat("CheckPointX", checkPointPosition.x);
                PlayerPrefs.SetFloat("CheckPointY", checkPointPosition.y);
                PlayerPrefs.SetFloat("CheckPointZ", checkPointPosition.z);



            }
        }
    }

}

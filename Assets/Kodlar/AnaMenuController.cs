using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuController : MonoBehaviour
{
    

    public void PlayButonu()
    {
        SceneManager.LoadScene("Level");
    }
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("AnaMenuSahnesi");
    }
}

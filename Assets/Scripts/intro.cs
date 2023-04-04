using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    public void OnEnable()
    {
        if (SceneManager.GetActiveScene().name == "Intro")
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        if (SceneManager.GetActiveScene().name == "Outro")
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
        
    }
}

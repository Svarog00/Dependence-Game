using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Image[] background;
    void Start()
    {
        
    }


    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit() 
    {
        Application.Quit();
    }
}

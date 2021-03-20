using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject visual;
    void Start()
    { 
        visual.SetActive(false);
    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit() 
    {
        Application.Quit();
    }

    public void VisualActive()
    {
        visual.SetActive(true);
    }
}

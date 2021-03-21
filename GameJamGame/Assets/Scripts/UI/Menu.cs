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
        Health.Instance.OnHeartEnded += Instance_OnHeartEnded;
        PlayerManager.Instance.OnPlayerDead += Instance_OnPlayerDead;
    }

    private void Instance_OnPlayerDead(object sender, System.EventArgs e)
    {
        EndGame();
    }

    private void Instance_OnHeartEnded(object sender, System.EventArgs e)
    {
        EndGame();
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

    private void EndGame()
    {
        Menu menu = FindObjectOfType<Menu>();
        menu.VisualActive();
        Time.timeScale = 0;
    }
}

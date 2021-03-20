using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public event EventHandler OnSpacePressed;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Press Space to start";
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            OnSpacePressed?.Invoke(this, EventArgs.Empty); //Call event to start start timer (facepalm, cringe)
        }
    }
}

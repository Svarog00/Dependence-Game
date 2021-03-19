using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public event EventHandler OnStartSignal;
    public event EventHandler<OnTimeChangedEventArgs> OnTimeChanged;
    public class OnTimeChangedEventArgs
    {
        public int currentTime;
    }

    public float time;

    private bool _startTimer = false;
    private float curTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        StartScreen startScreen = FindObjectOfType<StartScreen>();
        startScreen.OnSpacePressed += StartScreen_OnSpacePressed; //get event from start screen to start the game
    }

    private void StartScreen_OnSpacePressed(object sender, EventArgs e)
    {
        _startTimer = true;
        curTime = time;
        Debug.Log("Timer started!");
    }

    // Update is called once per frame
    void Update()
    {
        if(curTime > 0 && _startTimer)
        {
            curTime -= Time.deltaTime;
            OnTimeChanged?.Invoke(this, new OnTimeChangedEventArgs { currentTime = (int)curTime }); //call event to change the text field content
            if(curTime <= 0)
            {
                OnStartSignal?.Invoke(this, EventArgs.Empty);//call event to activate movement
            }
        }
    }
}

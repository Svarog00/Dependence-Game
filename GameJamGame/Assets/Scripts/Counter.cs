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

    private float curTime;
    // Start is called before the first frame update
    void Start()
    {
        curTime = time;
        Debug.Log("Timer started!");
    }

    // Update is called once per frame
    void Update()
    {
        if(curTime > 0)
        {
            curTime -= Time.deltaTime;
            OnTimeChanged?.Invoke(this, new OnTimeChangedEventArgs { currentTime = (int)curTime });
            Debug.Log($"Current Time: {curTime}");
            if(curTime <= 0)
            {
                OnStartSignal?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    public Text text;

    private Counter counter;
    private void Start()
    {
        counter = FindObjectOfType<Counter>();
        counter.OnTimeChanged += Counter_OnTimeChanged;
    }

    private void Counter_OnTimeChanged(object sender, Counter.OnTimeChangedEventArgs e)
    {
        text.text = e.currentTime.ToString(); //Show current time
        if(e.currentTime <= 0)
        {
            text.text = "Start!";
            counter.OnTimeChanged -= Counter_OnTimeChanged;
            text.CrossFadeAlpha(0, 1f, false);
        }
    }
}

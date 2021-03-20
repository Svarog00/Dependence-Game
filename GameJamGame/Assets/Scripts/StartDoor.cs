using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDoor : MonoBehaviour
{
    private Animator animator;
    private Collider2D collider;
    void Start()
    {
        collider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        Counter startScreen = FindObjectOfType<Counter>();
        startScreen.OnTimeChanged += StartScreen_OnTimeChanged;      
    }

    private void StartScreen_OnTimeChanged(object sender, Counter.OnTimeChangedEventArgs e)
    {
        if(e.currentTime <= 1.5f)
        {
            animator.Play("Door_Open");
            Invoke("SetActiveFalse", 1.5f);
        }
    }

    private void SetActiveFalse()
    {
        collider.isTrigger = true;
    }
}
